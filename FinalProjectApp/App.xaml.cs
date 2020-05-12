using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProjectApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static FinalProjectRepository.ComponentRepository _componentRepository;

        static App()
        {
            _componentRepository = new FinalProjectRepository.ComponentRepository();
        }

        public static FinalProjectRepository.ComponentRepository ContactRepository
        {
            get
            {
                return _componentRepository;
            }
        }

    }
}
