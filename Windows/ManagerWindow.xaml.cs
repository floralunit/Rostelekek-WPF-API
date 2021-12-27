using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Rostelekek_WPF_API.Windows;

namespace Rostelekek_WPF_API.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();

        }
        private async void ManagerWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var client = new HttpClient();
                HttpResponseMessage response = new HttpResponseMessage();
                var uri = new Uri("https://rostelekek.herokuapp.com/order");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                response = await client.GetAsync(uri);
                string json = response.Content.ReadAsStringAsync().Result;
                JArray o = JArray.Parse(json);
                JArray ob = JArray.Parse(o.ToString());
                var pipa = JsonConvert.DeserializeObject<List<Order>>(ob.ToString());
                orderList.ItemsSource = pipa.ToList();

                uri = new Uri("https://rostelekek.herokuapp.com/work-act");
                response = await client.GetAsync(uri);
                json = response.Content.ReadAsStringAsync().Result;
                o = JArray.Parse(json);
                ob = JArray.Parse(o.ToString());
                var pipa1 = JsonConvert.DeserializeObject<List<Work_Act>>(ob.ToString());
                orderProcessList.ItemsSource = pipa1.Where(p => p.state != "Завершен").ToList();

                var pipa2 = JsonConvert.DeserializeObject<List<Work_Act>>(ob.ToString());
                orderDoneList.ItemsSource = pipa2.Where(p => p.state == "Завершен").ToList();
            }
            catch
            {
                MessageBox.Show("Данные отсутствуют");
            }


        }

        private async void BCreate_Click(object sender, RoutedEventArgs e)
        {
            if (orderList.SelectedItem == null) return;
            // получаем выделенный объект
            Order order = orderList.SelectedItem as Order;

            ActAddWindow orderWindow = new ActAddWindow(order.id);
            orderWindow.Show();
        }
        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            new LoginWindow().Show();
            Close();
        }

        private void BRestart_Click(object sender, RoutedEventArgs e)
        {
            new ManagerWindow().Show();
            this.Close();
        }
        private void BMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void BClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void MainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
