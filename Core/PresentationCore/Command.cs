﻿using Core.Extensions;
using System;
using System.Windows.Input;

namespace Core.PresentationCore
{
    /// <summary>
    ///  Generic ICommand implementation to handle button events and such in WPF.
    /// </summary>
    public class Command
      : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public Command(Action<object> execute)
            : this(execute, null)
        {
        }
        public Command(Action<object> execute, Func<object, bool> canExecute)
        {
            execute.IsNotNull(nameof(execute));

            _execute = execute;
            _canExecute = canExecute ?? (x => true);
        }


        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public void Refresh()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
