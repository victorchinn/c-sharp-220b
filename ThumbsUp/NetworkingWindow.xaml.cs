using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ThumbsUp
{
    /// <summary>
    /// Interaction logic for NetworkingWindow.xaml
    /// </summary>
    public partial class NetworkingWindow : Window
    {
        public NetworkingWindow()
        {
            InitializeComponent();

            var _CatService = new CatService();

            var _CatModel  = _CatService.GetCat();

//            MessageBox.Show(_CatModel.Status..weather.First().main);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
