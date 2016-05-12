using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaNinja.Models
{
    public class PedidoModel
    {
        [Display(Name = "Data de entrega ")]
        [Required(ErrorMessage ="Informe a data de entrega.")]
        public DateTime DataDesejoEntrega { get; set; }

        [Display(Name = "Nome do produto ")]
        [Required(ErrorMessage = "Informe o nome do produto.")]
        public string NomeProduto { get; set; }

        [Display(Name = "Valor da venda ")]
        [Required(ErrorMessage = "Informe o valor da venda.")]
        public string ValorVenda { get; set; }

        [Display(Name = "Escolha um tipo de pagamento ")]
        public TipoPagamento TipoDePagamento { get; set; }

        [Display(Name = "Nome ")]
        [Required(ErrorMessage = "Informe seu nome.")]
        public string NomeCliente { get; set; }

        [Display(Name = "Cidade ")]
        [Required(ErrorMessage = "Informe a cidade.")]
        public string Cidade { get; set; }

        [Display(Name = "Estado ")]
        [Required(ErrorMessage = "Informe o estado.")]
        public string Estado { get; set; }
    }
}