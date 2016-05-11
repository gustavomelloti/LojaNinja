using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaNinja.Models
{
    public class PedidoModel
    {
        [Required(ErrorMessage ="Informe a data de desejo.")]
        public DateTime DataDesejoEntrega { get; set; }

        [Required(ErrorMessage = "Informe o nome do produto.")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "Informe o valor da venda.")]
        public double ValorVenda { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public string NomeCliente { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}