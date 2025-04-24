using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Finance_Project_actual_one_ignore_others.Core
{
    internal class RelayCommand : ICommand
        // i command lets me assign an action to execute so when 
        //a button is pressed and i want to execute something it lets me program the execution of the action
        // atleast thats what i understood
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
            // im not sure what this does i just copied this
        }
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
            // the actual command that relays with the action and function 
            // e.g clicking on a button and then the function takes me to another page
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
            // does the function canexecute which returns wheter it can execute or not
            // i think atleast not sure
        }
        public void Execute(object parameter)
        {
            _execute(parameter);
            // executes the object provided
        }
    }
}
