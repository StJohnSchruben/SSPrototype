using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SSMainControl.ViewModels.CustomControls
{
    public class ParamedRelayCommand : ICommand
    {
        
        Action<object> _executeMethod;

        public ParamedRelayCommand (Action<object> executeMethod)
        {
            _executeMethod = executeMethod;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }
    }
}
