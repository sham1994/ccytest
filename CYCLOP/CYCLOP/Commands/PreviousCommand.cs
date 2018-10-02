using CYCLOP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CYCLOP.Commands
{
   public class PreviousCommand: ICommand
    {


        private TestViewModel _viewmodel;
        public PreviousCommand(TestViewModel viewmodel)
            {

            _viewmodel = viewmodel;
            
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
            // throw new NotImplementedException();
            if (_viewmodel.Collection.View.CurrentPosition > 0) _viewmodel.Collection.View.MoveCurrentToPrevious();
        }



        #endregion







    }
}
