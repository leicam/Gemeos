using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces;
using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_wpf_14_04_2020.Formularios.Produto
{
    public partial class frmCadastrarProduto : Form
    {
        #region variaveis privadas

        private readonly IRepositorioProduto _repositorioProduto;
        private Dominio.Entidades.Produto _produto;

        #endregion variaveis privadas

        #region Construtores

        private frmCadastrarProduto(IRepositorioProduto repositorioProduto)
        {
            InitializeComponent();
            _repositorioProduto = repositorioProduto;
        }

        private frmCadastrarProduto(IRepositorioProduto repositorioProduto, Dominio.Entidades.Produto produto) : this(repositorioProduto)
        {
            _produto = produto;
            txbDescricao.Text = produto.Descricao;
            txbValor.Text = produto.Valor.ToString();
        }

        #endregion Construtores

        #region Metodos

        public static void Cadastrar(IRepositorioProduto repositorioProduto)
        {
            var tela = new frmCadastrarProduto(repositorioProduto);
            tela.ShowDialog();
        }

        public static void Editar(IRepositorioProduto repositorioProduto, Dominio.Entidades.Produto produto)
        {
            var tela = new frmCadastrarProduto(repositorioProduto, produto);
            tela.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_produto == null)
                    CadastrarProduto();
                else
                    EditarProduto();

                Close();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditarProduto()
        {
            _produto.SetDescricao(GetDescricaoProduto());
            _produto.SetValor(GetValorProduto());
            _repositorioProduto.Update(_produto);
        }

        private void CadastrarProduto()
            => _repositorioProduto.Add(new Dominio.Entidades.Produto(GetDescricaoProduto(), GetValorProduto()));

        private decimal GetValorProduto()
        {
            decimal.TryParse(txbValor.Text, out decimal resultado);
            return resultado;
        }

        private string GetDescricaoProduto() => txbDescricao.Text;

        #endregion Metodos
    }
}