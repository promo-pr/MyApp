using System.Windows;

namespace MyApp.Client.Views
{
    /// <summary>
    /// Interaction logic for OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        public OrdersWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) 
        {
            OrderEditWindow win = new OrderEditWindow();
            win.Show();
        }
    }
}
