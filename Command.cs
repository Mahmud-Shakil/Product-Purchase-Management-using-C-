using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace Product_Purchase_Management
{
    public class Command : ICommand
    {
        private Action methodToExecute = null;
        private Func<bool> methodToDectCanExecute = null;
        private DispatcherTimer canExecuteChangedEventTimer = null;
        public Command(Action methodToExcute, Func<bool> methodToDetctCanExecute)
        {
            this.methodToExecute = methodToExcute;
            this.methodToDectCanExecute = methodToDetctCanExecute;
            this.canExecuteChangedEventTimer = new DispatcherTimer();
            this.canExecuteChangedEventTimer.Tick += canExecuteChangedEventTimer_Tick;
            this.canExecuteChangedEventTimer.Interval = new TimeSpan(0, 0, 1);
            this.canExecuteChangedEventTimer.Start();
        }
        

        public bool CanExecute(object parameter)
        {
            if (this.methodToDectCanExecute == null) 
            {
                return true;
            }
            else
            {
                return this.methodToDectCanExecute();
            }
        }
        public event EventHandler CanExecuteChanged;
        void canExecuteChangedEventTimer_Tick(object sender, object e)
        {
            if (this.CanExecuteChanged != null)
            {
                this.CanExecuteChanged(this, EventArgs.Empty);
            }
        }
        public void Execute(object parameter)
        {
            this.methodToExecute();
        }
       
    }

    
}
