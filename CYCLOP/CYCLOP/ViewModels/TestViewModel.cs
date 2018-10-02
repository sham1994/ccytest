using CYCLOP.Commands;
using CYCLOP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CYCLOP.ViewModels
{
   

    public class TestViewModel: INotifyPropertyChanged

    {
        public CollectionViewSource Collection { get; private set; }
        private SampleDBLiteEntities _ctx;


      
        public TestViewModel()
        {

            Collection = new CollectionViewSource();
            LoadData();

            #region CommandExecution
            NextEvent = new NextCommand(this);

            PreviousEvent = new PreviousCommand(this);

            AddEvent = new AddCommand(this);

            SaveEvent = new SaveCommand(this);

            #endregion

        }
        private void LoadData()
        {
            Refresh();

        }
        public void Refresh()
        {
            _ctx = new SampleDBLiteEntities();
            _ctx.Users.Load();
            Collection.Source = _ctx.Users.Local;
         }

        #region SelectedItem
        private User _selectedItem;

        

        public User SelectedItem
        {
            get
            {
                return    _selectedItem;

            }
            set
            {
                _selectedItem = value;
                NoticeMe("SelectedItem");
                ButtonAddContent = "Add";


            }

        }

        #endregion

        public void Add()
        {
            _ctx.Users.Add(SelectedItem);
          

        }
        public void SaveChanges()
        {
            if (ButtonAddContent == "Cancel")
            {
                Add();
            }
            _ctx.SaveChanges();
            ButtonAddContent = "Add";
        }

        #region ButtonAddContent Full Property


        private string _buttonAddContent;
        public string ButtonAddContent
        {
            get
            {
                return _buttonAddContent;

            }
            set
            {
                _buttonAddContent = value;
                NoticeMe("ButtonAddContent");

            }
        }
        #endregion

        #region INotifyPropertyChanged
        protected void NoticeMe(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(property));

        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Commands

        public NextCommand NextEvent { get; private set; }
        public PreviousCommand PreviousEvent    { get; set; }


        public AddCommand AddEvent { get;  set; }

        public SaveCommand SaveEvent { get; set; }
        #endregion
    }
}
