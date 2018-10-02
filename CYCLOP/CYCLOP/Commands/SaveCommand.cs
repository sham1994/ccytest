using CYCLOP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CYCLOP.Commands
{
    public class SaveCommand : ICommand

    {

        private TestViewModel _viewmodel;


        public SaveCommand(TestViewModel viewmodel)
        {

            _viewmodel = viewmodel;
        }
        #region Savecommand
        public event EventHandler CanExecuteChanged

        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            // throw new NotImplementedException();
            _viewmodel.SaveChanges();
        }

        #endregion


    }
}
