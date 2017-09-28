using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste.Models
{
    public class Tarifas
    {
        public List<Tarifa> Itens { get; set; } 

        public Tarifas()
        {
            Itens = new List<Tarifa>();

            Itens.Add(new Tarifa(Prefixo.Onze, Prefixo.Dezesseis, 1.9M));
            
            Itens.Add(new Tarifa(Prefixo.Dezesseis , Prefixo.Onze, 2.9M));
            
            Itens.Add( new Tarifa(Prefixo.Onze, Prefixo.Dezessete, 1.7M));
            
            Itens.Add(new Tarifa(Prefixo.Dezessete, Prefixo.Onze, 2.7M));
            
            Itens.Add(new Tarifa(Prefixo.Onze, Prefixo.Dezoito, 0.9M));

            Itens.Add(new Tarifa(Prefixo.Dezoito, Prefixo.Onze, 1.9M));

        }

    }

    public class Tarifa
    {

        public Prefixo Destino { get; set; }

        public Prefixo Origem { get; set; }

        public decimal Valor { get; set; }

        public Tarifa(Prefixo origem, Prefixo destino, decimal valor)
        {
            Destino = destino;
            
            Origem = origem;

            Valor = valor;

        }

    }
}