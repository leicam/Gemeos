using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemos.WPF.Models.Produto
{
    public class ProdutoModel : AbstractModel
    {
        private string _descricao;
        private decimal _valor;

        public string Descricao
        {
            get => _descricao;
            set => SetField(ref _descricao, value);
        }

        public decimal Valor
        {
            get => _valor;
            set => SetField(ref _valor, value);
        }

        public ProdutoModel() { }

        public ProdutoModel(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}
