using Gemos.WPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gemos.WPF.Views.Produto
{
    public class CadastrarProdutoCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            try
            {
                var vm = (parameter as CadastrarProdutoViewModel);
                vm.Connector.ProdutoConnector.Add(new aula_wpf_14_04_2020.Dominio.Entidades.Produto(vm.Produto.Descricao, vm.Produto.Valor));
                MessageBox.Show("Produto cadastrado com sucesso!");
                vm.ExecutarComando(vm.FecharJanela);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
