using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace HomeworkAssignment02_WPF.Models
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Users> _DataCollection;
        private ObservableCollection<Users> _DataCollectionAfter;

        public ViewModel()
        {
            _DataCollection = new ObservableCollection<Users>();
            _DataCollectionAfter = new ObservableCollection<Users>();
            LoadInitialDataForUnsorted();

        }
        public void LoadInitialDataForUnsorted()
        {
            _DataCollection.Add(new Models.Users { Name = "Dave", Password = "hello" });
            _DataCollection.Add(new Models.Users { Name = "Steve", Password = "steve" });
            _DataCollection.Add(new Models.Users { Name = "Lisa", Password = "hello" });
        }


        public void LoadInitialDataForSorted()
        {
            _DataCollection.Add(new Models.Users { Name = "Dave", Password = "1DavePwd" });
            _DataCollection.Add(new Models.Users { Name = "Steve", Password = "2StevePwd" });
            _DataCollection.Add(new Models.Users { Name = "Lisa", Password = "3LisaPwd" });
        }

        public ObservableCollection<Users> DataCollection
        {
            get { return _DataCollection; }
            set { _DataCollection = value; }
        }

        public ObservableCollection<Users> DataCollectionAfter
        {
            get { return _DataCollectionAfter; }
            set { _DataCollectionAfter = value; }
        }

        // INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
