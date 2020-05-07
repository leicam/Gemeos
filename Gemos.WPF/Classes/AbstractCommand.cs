using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Gemos.WPF.Classes
{
    public abstract class AbstractCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter) => true;
        public void RaizeCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public virtual void CloseWindow() => Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive)?.Close();
        public abstract void Execute(object parameter);
    }
}
