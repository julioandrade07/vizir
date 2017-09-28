using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Teste.Models;

namespace Teste.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ConfigureViewbag();

            return View(new CalculoVM());
        }

        [HttpPost]
        public ActionResult Index(CalculoVM vm)
        {
            try
            {
                var tarifas = new Tarifas();

                var tarifa = tarifas.Itens.FirstOrDefault(x => (int)x.Destino == vm.Destino && (int)x.Origem == vm.Origem);

                var plano = (Plano)vm.PlanoId;

                if (tarifa == null)
                {
                    ConfigureViewbag();
                    ModelState.AddModelError("", "DDD não Encontrado");
                    return View(vm);
                }

                vm.Calcular(tarifa, plano);

                ConfigureViewbag();

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);     
            }
          
            return View(vm);
        }

        private void ConfigureViewbag()
        {
            ViewBag.Planos = Enum.GetValues(typeof(Plano)).Cast<Plano>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList();

        }

    }
}
