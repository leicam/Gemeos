using Gemos.WPF.Classes;
using Gemos.WPF.Connectors;
using Gemos.WPF.Views.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemos.WPF.Views
{
    public class AbstractViewModel : AbstractNofityPropertyChanged
    {
        public Connector Connector { get; private set; } = Connector.Factory();

        public FecharJanela FecharJanela { get; private set; } = new FecharJanela();

        public void ExecutarComando(AbstractCommand command)
        {
            if (command.CanExecute(this))
                command.Execute(this);
        }
    }
}
