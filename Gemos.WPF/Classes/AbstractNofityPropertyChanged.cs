using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Gemos.WPF.Classes
{
    public abstract class AbstractNofityPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetField<T>(ref T field, T value, [CallerMemberName] string nomeProperty = null)
        {
            if(!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaizePropertyChange(nomeProperty);
            }
        }

        private void RaizePropertyChange(string nomeProperty)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomeProperty));
    }
}