using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace employee_management_system.Model
{
   public class command : ICommand
    {
        Action<object> executemethod;
        Func<object, bool> canexecutemethod;

        public command(Action<object> executemethod, Func<object, bool> canexecutemethod)
        {
            this.executemethod = executemethod;
            this.canexecutemethod = canexecutemethod;
        }
      

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executemethod(parameter);
        }
        public event EventHandler CanExecuteChanged;
    }
}
