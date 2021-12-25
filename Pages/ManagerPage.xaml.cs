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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Rostelekek_WPF_API.Pages
{
    /// <summary>
    /// Логика взаимодействия для MahagerPage.xaml
    /// </summary>
    public partial class MahagerPage : Page
    {
        public MahagerPage()
        {
            InitializeComponent();

        }
        private async void ManagerPage_Loaded(object sender, RoutedEventArgs e)
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

        }
        private void BEdit_Click(object sender, RoutedEventArgs e)
        {

        }
        private async void BDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void BCreate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
