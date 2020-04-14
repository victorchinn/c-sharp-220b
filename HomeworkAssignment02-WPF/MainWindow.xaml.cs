using HomeworkAssignment02_WPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HomeworkAssignment02_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ViewModel MainAppViewModel = new ViewModel();


        public MainWindow()
        {
            InitializeComponent();
            MainWindowView.DataContext = MainAppViewModel;
            MainWindowListView.Items.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }

        private void First_Action_Click(object sender, RoutedEventArgs e)
        {
            var answers = from Users in MainAppViewModel.DataCollection
                                                   where Users.Password == "hello"
                                                   select Users;
            MainAppViewModel.DataCollectionAfter.Clear();   // SELECT ONLY THE USERS == "hello" AND DISPLAY THEM SEPARATELY
            foreach (Users _EachUSER in answers)
            {
                MainAppViewModel.DataCollectionAfter.Add(_EachUSER);
            }
        }

        private void Second_Action_Click(object sender, RoutedEventArgs e)
        {
            var answers = from Users in MainAppViewModel.DataCollection
                          where Users.Password.ToLower() == Users.Name.ToLower()
                          select Users;

            foreach (Users _EachUSER in answers)
            {
                _EachUSER.Password = "";
            }

        }

        private void Third_Action_Click(object sender, RoutedEventArgs e)
        {

            if (MainAppViewModel.DataCollection.Count != 0)
            {
                try
                {
                    Users answers = MainAppViewModel.DataCollection.Where(x => x.Password == "hello").First();

                    MainAppViewModel.DataCollection.Remove(answers);

                    MainWindowListView.Items.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
                }
                catch(Exception Ex)
                {
                    MessageBox.Show($"No password == \"hello\" in list. {Ex.Message}.");
                }
            }


        }

        private void Fourth_Action_Click(object sender, RoutedEventArgs e)
        {
            MainAppViewModel.DataCollection.Clear();
            MainAppViewModel.DataCollectionAfter.Clear();

            First_Action.IsEnabled = false;
            Second_Action.IsEnabled = false;
            Third_Action.IsEnabled = false;
            Fourth_Action.IsEnabled = false;

            LoadListForSorted.IsEnabled = true;
            LoadListForUnsorted.IsEnabled = true;


        }

        private void MainWindowListView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // NOTE THIS ONLY WORKS IF THE MOUSE IS PRESSED ON ANY WHERE WITHIN THE LISTVIEW

            if (MainWindowListView.HasItems)
            {
                // toggle it
                if (MainWindowListView.Items.SortDescriptions[0].Direction == ListSortDirection.Ascending)
                {
                    MainWindowListView.Items.SortDescriptions.Clear();
                    MainWindowListView.Items.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Descending));
                }
                else
                {
                    MainWindowListView.Items.SortDescriptions.Clear();
                    MainWindowListView.Items.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
                }
            }
        }


        private void LoadListForUnsorted_Click(object sender, RoutedEventArgs e)
        {
            MainAppViewModel.LoadInitialDataForUnsorted();
            First_Action.IsEnabled = true;
            Second_Action.IsEnabled = true;
            Third_Action.IsEnabled = true;
            Fourth_Action.IsEnabled = true;

            LoadListForSorted.IsEnabled = false; 

        }

        private void LoadListForSorted_Click(object sender, RoutedEventArgs e)
        {
            MainAppViewModel.LoadInitialDataForSorted();
            First_Action.IsEnabled = false;
            Second_Action.IsEnabled = false;
            Third_Action.IsEnabled = false;
            Fourth_Action.IsEnabled = true;

            LoadListForUnsorted.IsEnabled = false;
        }

        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;

        private void lvUsersColumnHeader_Click(object sender, RoutedEventArgs e)
        {


            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                MainWindowListView.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            MainWindowListView.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));



        }







        public class SortAdorner : Adorner
        {
            private static Geometry ascGeometry =
                Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");

            private static Geometry descGeometry =
                Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

            public ListSortDirection Direction { get; private set; }

            public SortAdorner(UIElement element, ListSortDirection dir)
                : base(element)
            {
                this.Direction = dir;
            }

            protected override void OnRender(DrawingContext drawingContext)
            {
                base.OnRender(drawingContext);

                if (AdornedElement.RenderSize.Width < 20)
                    return;

                TranslateTransform transform = new TranslateTransform
                    (
                        AdornedElement.RenderSize.Width - 15,
                        (AdornedElement.RenderSize.Height - 5) / 2
                    );
                drawingContext.PushTransform(transform);

                Geometry geometry = ascGeometry;
                if (this.Direction == ListSortDirection.Descending)
                    geometry = descGeometry;
                drawingContext.DrawGeometry(Brushes.Black, null, geometry);

                drawingContext.Pop();
            }
        }
    }
}
