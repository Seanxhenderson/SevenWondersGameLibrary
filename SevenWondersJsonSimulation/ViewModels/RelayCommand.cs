using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SevenWondersJsonSimulation.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Action action;
        private readonly Func<bool> condition;

        public RelayCommand(Action action)
        {
            this.action = action;
            this.condition = () => true;
        }

        public RelayCommand(Action action, Func<bool> condition)
        {
            this.action = action;
            this.condition = condition;
        }

        public event EventHandler CanExecuteChanged = delegate { };

        public void RaiseExecuteChanged()
        {
            this.CanExecuteChanged(this, EventArgs.Empty);
        }

        public bool CanExecute(object parameter)
        {
            return this.condition();
        }

        public void Execute(object parameter)
        {
            this.action();
        }
    }
}
