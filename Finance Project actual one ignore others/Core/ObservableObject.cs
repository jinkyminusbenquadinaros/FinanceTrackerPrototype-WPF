using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Project_actual_one_ignore_others.Core
{
    internal class ObservableObject : INotifyPropertyChanged
        // notifies client a value of a property has changed or something
        // i can use it for updating the ui when its bound to something
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
                // if this isnt null we want to invoke it
        }
    }
}
