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
        List<Worker> workers = new List<Worker>();
        List<Customer> customers = new List<Customer>();
        List<Service> services = new List<Service>();
        List<Equip> equips = new List<Equip>();
        List<Order> orders = new List<Order>();
        List<Work_Act> acts = new List<Work_Act>();
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
                orders = pipa.ToList();

                uri = new Uri("https://rostelekek.herokuapp.com/equipment");
                response = await client.GetAsync(uri);
                json = response.Content.ReadAsStringAsync().Result;
                o = JArray.Parse(json);
                ob = JArray.Parse(o.ToString());
                var pipa2 = JsonConvert.DeserializeObject<List<Equip>>(ob.ToString());
                equips = pipa2.ToList();

                uri = new Uri("https://rostelekek.herokuapp.com/customer");
                response = await client.GetAsync(uri);
                json = response.Content.ReadAsStringAsync().Result;
                o = JArray.Parse(json);
                ob = JArray.Parse(o.ToString());
                var pipa3 = JsonConvert.DeserializeObject<List<Customer>>(ob.ToString());
                customers = pipa3.ToList();

                for (int or = 0; or < orders.Count(); or++)
                {
                    for (int c = 0; c < customers.Count(); c++)
                    {
                            for (int eq = 0; eq < equips.Count(); eq++)
                            {
                                if (orders[or].id_equip == equips[eq].id && orders[or].id_customer == customers[c].id)
                                {
                                    orders[or].customer = customers[c].name;
                                    orders[or].equip =equips[eq].name;
                                }
                            }
                    }
                }
                orderList.ItemsSource = orders.ToList();

                uri = new Uri("https://rostelekek.herokuapp.com/worker");
                response = await client.GetAsync(uri);
                json = response.Content.ReadAsStringAsync().Result;
                o = JArray.Parse(json);
                ob = JArray.Parse(o.ToString());
                var pipa4 = JsonConvert.DeserializeObject<List<Worker>>(ob.ToString());
                workers = pipa4.ToList();

                uri = new Uri("https://rostelekek.herokuapp.com/work-act");
                response = await client.GetAsync(uri);
                json = response.Content.ReadAsStringAsync().Result;
                o = JArray.Parse(json);
                ob = JArray.Parse(o.ToString());
                var pipa10 = JsonConvert.DeserializeObject<List<Work_Act>>(ob.ToString());
                acts = pipa10.ToList();


                for (int a=0;a< acts.Count();a++)
                {
                    for (int w = 0; w < workers.Count(); w++)
                    {
                        if (acts[a].id_worker == workers[w].id) acts[a].worker = workers[w].name;
                    }
                }
                orderProcessList.ItemsSource = acts.Where(p => p.state != "Завершен").ToList();

                var pipa5 = JsonConvert.DeserializeObject<List<Work_Act>>(ob.ToString());
                acts = pipa5;
                orderDoneList.ItemsSource = acts.Where(p => p.state == "Завершен").ToList();

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
