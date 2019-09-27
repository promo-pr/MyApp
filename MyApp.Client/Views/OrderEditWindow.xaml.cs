using MyApp.Core.Models;
using System.Text.Json;
using System.Windows;

namespace MyApp.Client.Views
{
    /// <summary>
    /// Логика взаимодействия для OrderEditWindow.xaml
    /// </summary>
    public partial class OrderEditWindow : Window
    {
        public OrderEditWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order { Price = int.Parse(PriceBox.Text), Description = DescriptionBox.Text };
            var js = JsonSerializer.Serialize(order);
        }
    }
}
