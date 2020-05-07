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
    public partial class frmListarProduto : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public frmListarProduto(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto.Cadastrar(_unitOfWork.RepositorioProduto);
            CarregarProdutos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto.Editar(_unitOfWork.RepositorioProduto, dgvProdutos.CurrentRow.DataBoundItem as Dominio.Entidades.Produto);
            RecarregarProdutos();
        }

        private void frmListarProduto_Load(object sender, EventArgs e) => CarregarProdutos();

        private void CarregarProdutos()
            => dgvProdutos.DataSource = _unitOfWork.RepositorioProduto.GetAll().ToList();

        private void RecarregarProdutos()
            => dgvProdutos.Refresh();
    }
}