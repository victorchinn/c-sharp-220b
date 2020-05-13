using FinalProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProjectApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ComponentModel _selectedComponent;

        private void uxComponentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedComponent = (ComponentModel)uxComponentList.SelectedValue;
        }
        public MainWindow()
        {
            InitializeComponent();
            LoadContacts();
        }

        private void LoadContacts()
        {
            var contacts = App.ComponentRepository.GetAll();

            uxComponentList.ItemsSource = contacts
                .Select(t => ComponentModel.ToModel(t))
                .ToList();

            // OR
            //var uiContactModelList = new List<ContactModel>();
            //foreach (var repositoryContactModel in contacts)
            //{
            //    This is the .Select(t => ... )
            //    var uiContactModel = ContactModel.ToModel(repositoryContactModel);
            //
            //    uiContactModelList.Add(uiContactModel);
            //}

            //uxContactList.ItemsSource = uiContactModelList;
        }

        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new ComponentWindow();

            if (window.ShowDialog() == true)
            {
                var uiComponentModel = window.Component;

                var repositoryContactModel = uiComponentModel.ToRepositoryModel();

                App.ComponentRepository.Add(repositoryContactModel);

                // OR
                //App.ContactRepository.Add(window.Contact.ToRepositoryModel());

                LoadContacts();
            }
        }
        private void WindowMainMENU_FileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new ComponentWindow();
            if (window.ShowDialog() == true)
            {
                var uiComponentModel = window.Component;
                var repositoryComponentModel = uiComponentModel.ToRepositoryModel();
                App.ComponentRepository.Add(repositoryComponentModel);
                // OR
                //App.ComponentRepository.Add(window.Component.ToRepositoryModel());
            }
        }

        private void WindowMainMENU_FileDelete_Click(object sender, RoutedEventArgs e)
        {

            App.ComponentRepository.Remove(_selectedComponent.Id);
            _selectedComponent = null;
            LoadContacts();
        }

        private void WindowMainMENU_FileDelete_Loaded(object sender, RoutedEventArgs e)
        {
            WindowMainMENU_FileDelete.IsEnabled = (_selectedComponent != null);
        }

        private void WindowMainMENU_FileModify_Click(object sender, RoutedEventArgs e)
        {
            var window = new ComponentWindow();
//            window.Component = _selectedComponent;    // original code
            window.Component = ((ComponentModel)_selectedComponent.Clone());   // GET A CLONE OF ITSELF TO THE WINDOW




            if (window.ShowDialog() == true)
            {
                App.ComponentRepository.Update(window.Component.ToRepositoryModel());
                LoadContacts();
            }
        }

        private void WindowMainMENU_FileModify_Loaded(object sender, RoutedEventArgs e)
        {
            WindowMainMENU_FileModify.IsEnabled = (_selectedComponent != null);
            uxContextMENU_FileModify.IsEnabled = WindowMainMENU_FileModify.IsEnabled;
        }

        private void uxComponentList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var window = new ComponentWindow();
            window.Component = _selectedComponent;
            if (window.ShowDialog() == true)
            {
                App.ComponentRepository.Update(window.Component.ToRepositoryModel());
                LoadContacts();
            }
        }
    }
}
