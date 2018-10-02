using CYCLOP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CYCLOP.Commands
{
    public class NextCommand : ICommand
    {

        
        private TestViewModel _viewModel;

        public NextCommand(TestViewModel viewmodel)
        {

            _viewModel = viewmodel;

        }

        #region ICommand
        public event EventHandler CanExecuteChanged
        {

            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();
            if (_viewModel.Collection.View.CurrentPosition < _viewModel.Collection.View.SourceCollection.Cast<object>().Count() - 1) _viewModel.Collection.View.MoveCurrentToNext(); 
        }
        #endregion
    }
}
