using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace ImmoLib
{
    /// <summary>
    /// A command whose sole purpose is to 
    /// relay its functionality to other
    /// objects by invoking delegates. The
    /// default return value for the CanExecute
    /// method is 'true'.
    /// </summary>
    public class RelayCommand<T> : ICommand
    {
        #region Fields
        Action<T> _execute { get; set; }
        Predicate<T> _canExecute { get; set; }

        #endregion // Fields

        #region Constructor

        public RelayCommand(Action<T> execute, Predicate<T> canExecute) 
        {
            this._canExecute = canExecute;

            if (execute == null)
                throw new ArgumentNullException("execute","Bitte den Command spezifizieren");

            this._execute = execute;
        }


        #endregion // Constructors

        #region ICommand Members

        public void RaiseCanExecuteChanged()
        { if (this.CanExecuteChanged != null)
                this.CanExecuteChanged(this, null);
                }
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute((T)parameter) == true; 
        }

        public event EventHandler CanExecuteChanged;
       

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }
        #endregion // ICommand Members
    }
}