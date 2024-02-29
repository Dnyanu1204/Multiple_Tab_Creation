using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace Multiple_Tab_Creation.MyCommand
{
    class Mycommand:ICommand
    {
        // The action to execute
        private readonly Action _execute;

    // The predicate to determine if the command can execute
    private readonly Predicate<object> _canExecute;

    // The event handler for the CanExecuteChanged event
    public event EventHandler CanExecuteChanged;

    // The constructor with only the execute action
    public Mycommand(Action execute) : this(execute, null)
    {
            _execute = execute;
    }

    // The constructor with both the execute action and the can execute predicate
    public Mycommand(Action execute, Predicate<object> canExecute)
    {
        // Check if the execute action is null
        if (execute == null)
        {
            // Throw an exception
            throw new ArgumentNullException(nameof(execute));
        }
        // Assign the fields
        _execute = execute;
        _canExecute = canExecute;
    }

    // A method to determine if the command can execute
    public bool CanExecute(object parameter)
    {
        // Return true if the can execute predicate is null, or invoke it with the parameter
        return _canExecute == null || _canExecute(parameter);
    }

    // A method to execute the command
    public void Execute(object parameter)
    {
        // Invoke the execute action
        _execute();
    }

    // A method to raise the CanExecuteChanged event
    public void RaiseCanExecuteChanged()
    {
        // Invoke the event handler if not null
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }



}

}
