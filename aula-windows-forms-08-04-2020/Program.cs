using aula_wpf_14_04_2020.Infraestrutura.IoC;
using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Formularios.Inicial;
using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var container = Installer.Factory();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTelaPrincipal(container.GetInstance<IUnitOfWork>()));
        }
    }
}