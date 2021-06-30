using System;
using System.Windows;
using System.Windows.Controls;
using Pra.Transportation.Core.Services;

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

        void ShowMeansOfTransport()
        {
            lstMeansOfTransport.ItemsSource = transportService.Movables;
            lstMeansOfTransport.Items.Refresh();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowMeansOfTransport();
        }

        private void LstPersons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
