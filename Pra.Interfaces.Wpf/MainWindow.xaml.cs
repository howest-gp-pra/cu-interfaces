using Pra.Transportation.Core.Services;
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

namespace Pra.Interfaces.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TransportService transportService = new TransportService();

        public MainWindow()
        {
            InitializeComponent();
        }

        void ShowFeedback(string feedback, bool isError = true)
        {
            tbkFeedBack.Visibility = Visibility.Visible;
            tbkFeedBack.Text = feedback;
            tbkFeedBack.Background = isError ? Brushes.IndianRed : Brushes.DeepSkyBlue;
        }

        void ShowMeansOfTransport()
        {
            lstMeansOfTransport.ItemsSource = transportService.Movables;
            lstMeansOfTransport.Items.Refresh();
            lstMeansOfTransport.DisplayMemberPath = "TransportationInfo";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowMeansOfTransport();
            tbkFeedBack.Visibility = Visibility.Hidden;
        }

        private void LstPersons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
