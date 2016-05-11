using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaNinja.Models
{
    public class PedidoModel
    {
        public DateTime DataDesejoEntrega { get; set; }
        public string NomeProduto { get; set; }
        public double ValorVenda { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public string NomeCliente { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}