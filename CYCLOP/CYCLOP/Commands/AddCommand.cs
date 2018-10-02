using CYCLOP.Models;
using CYCLOP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CYCLOP.Commands
{
    public class AddCommand : ICommand
    {

        private TestViewModel _viewmodel;

        public AddCommand(TestViewModel viewmodel)
        {

            _viewmodel = viewmodel;



        }
                           
                #region ICommand

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }

        }

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            // throw new NotImplementedException();
            if (_viewmodel.ButtonAddContent == "Add")
            {
                User addresult = new User();

                _viewmodel.SelectedItem = addresult;
                _viewmodel.ButtonAddContent = "Cancel";
                



            }
            else
            {
                _viewmodel.SelectedItem = _viewmodel.Collection.View.CurrentItem as User;
            }
        }

        #endregion
    }
}
