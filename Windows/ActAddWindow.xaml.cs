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
    /// Логика взаимодействия для WorkActWindow.xaml
    /// </summary>
    
    public partial class ActAddWindow : Window
    {
        int id;
        List<Worker> workers = new List<Worker>();
        public ActAddWindow(int _id)
        {
            InitializeComponent();
                id = _id;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var httpClient = new HttpClient();
                var url = "https://rostelekek.herokuapp.com";
                var client = new OrderControllerClient(url, httpClient);
                var order = client.FindOneAsync(id).Result;
                this.DataContext = order;
        }
        private async void ActAddWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            var uri = new Uri("https://rostelekek.herokuapp.com/worker");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            response = await client.GetAsync(uri);
            string json = response.Content.ReadAsStringAsync().Result;
            JArray o = JArray.Parse(json);
            JArray ob = JArray.Parse(o.ToString());
            var pipa = JsonConvert.DeserializeObject<List<Worker>>(ob.ToString());
            workers = pipa.ToList();
            CBWorker.ItemsSource = pipa;

        }
        private async void AcceptCreate_Click(object sender, RoutedEventArgs e)
        {
            int id_worker, w = 0;
            if (CBWorker.SelectedItem != null)
            {
                w = CBWorker.SelectedIndex;
                id_worker = workers[w].id;
            } else return;
            var workact = new CreateWorkActDto()
            {
                Id_order = id,
                Id_worker = id_worker,
                State = "Наряд отправлен"
            };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var httpClient = new HttpClient();
            var url = "https://rostelekek.herokuapp.com";
            var client = new WorkActControllerClient(url, httpClient);
            var _workkact = client.CreateAsync(workact);
            MessageBox.Show("Наряд был успешно отправлен!");
            Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
