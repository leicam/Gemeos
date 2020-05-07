using aula_wpf_14_04_2020.Formularios.Produto;
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

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Formularios.Inicial
{
    public partial class frmTelaPrincipal : Form
    {
        private IUnitOfWork _unitOfWork;

        public frmTelaPrincipal(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            var tela = new frmListarProduto(_unitOfWork);
            tela.ShowDialog();
        }
    }
}
