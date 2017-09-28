using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste.Models
{
    public class CalculoVM
    {
   
        public int Origem { get; set; }
        
        public int PlanoId { get; set; }

        public int Destino { get; set; }

        public int Tempo { get; set; }

        public bool Calculado { get; set; }

        public decimal ValorCom { get; set; }

        public decimal ValorSem { get; set; }

        public CalculoVM()
        {
            Calculado = false;
        }

        public void Calcular(Tarifa tarifa,  Plano plano)
        {
            if (Tempo > (int)plano)
                ValorCom = (Tempo - (int) plano) * tarifa.Valor;
            else
                ValorCom = 0;

            ValorSem = tarifa.Valor * Tempo;

            Calculado = true;

        }



    }
}