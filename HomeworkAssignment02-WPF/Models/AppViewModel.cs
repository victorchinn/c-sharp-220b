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

        public ViewModel()
        {
            _DataCollection = new ObservableCollection<Users>();
            LoadInitialData();

        }

        public void LoadInitialData()
        {
            _DataCollection.Add(new Models.Users { Name = "Dave", Password = "hello" });
            _DataCollection.Add(new Models.Users { Name = "Steve", Password = "steve" });
            _DataCollection.Add(new Models.Users { Name = "Lisa", Password = "hello" });
        }

        public ObservableCollection<Users> DataCollection
        {
            get { return _DataCollection; }
            set { _DataCollection = value; }
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
