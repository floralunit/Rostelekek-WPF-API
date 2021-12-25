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
            //var client = new HttpClient();
            //HttpResponseMessage response = new HttpResponseMessage();
            //var uri = new Uri("https://rostelekek.herokuapp.com/order");
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //response = await client.GetAsync(uri);
            //string json = response.Content.ReadAsStringAsync().Result;
            //JArray o = JArray.Parse(json);
            //JArray ob = JArray.Parse(o.ToString());
            //var pipa = JsonConvert.DeserializeObject<List<Order>>(ob.ToString());
            //orderList.ItemsSource = pipa.ToList();


            //var client = new HttpClient();
            //HttpResponseMessage response = new HttpResponseMessage();
            //var uri = new Uri("https://rostelekek.herokuapp.com/work-act");
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //response = await client.GetAsync(uri);
            //string json = response.Content.ReadAsStringAsync().Result;
            //JArray o = JArray.Parse(json);
            //JArray ob = JArray.Parse(o.ToString());
            //var pipa = JsonConvert.DeserializeObject<List<Work_Act>>(ob.ToString());
            //orderProcessList.ItemsSource = pipa.ToList();

            //uri = new Uri("https://rostelekek.herokuapp.com/WorkAct");
            //response = await client.GetAsync(uri);
            //json = response.Content.ReadAsStringAsync().Result;
            //JArray o1 = JArray.Parse(json);
            //JArray ob1 = JArray.Parse(o1.ToString());
            //var pipa1 = JsonConvert.DeserializeObject<List<Work_Act>>(ob1.ToString());
            //orderProcessList.ItemsSource = pipa1.ToList();
            //orderDoneList.ItemsSource = pipa1.ToList();

        }

        private async void BCreate_Click(object sender, RoutedEventArgs e)
        {

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
