using Gemos.WPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemos.WPF.Views.Commands
{
    public class FecharJanela : AbstractCommand
    {
        public override void Execute(object parameter) => CloseWindow();
    }
}
