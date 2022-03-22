using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hotel.MVVM.Command
{
    public class Command : ICommand
    {
        protected Action<object> _command;
        protected Predicate<object> _predicate;

        public event EventHandler? CanExecuteChanged;
        public virtual bool CanExecute(object parametr)
        {
            return _predicate(parametr);
        }
        public virtual void Execute(object parametr)
        {
            _command(parametr);
        }
        public virtual void OnCanExecuteChanged( object sender, EventArgs e)
        {
            CanExecuteChanged?.Invoke(sender, e);
        }
    }
}
