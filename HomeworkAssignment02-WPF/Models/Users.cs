using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkAssignment02_WPF.Models
{
    public class Users
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
            }
        }

        private string _Password ;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
            }
        }


    }
}
