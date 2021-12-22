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
    
    public partial class AdminWindow : Window
    {
        List<Worker> workers = new List<Worker>();
        public AdminWindow()
        {
            InitializeComponent();

        }
        private async void AdminWindow_Loaded(object sender, RoutedEventArgs e)
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
            LViewWorkers.ItemsSource = pipa.ToList();
        }
        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            if (LViewWorkers.SelectedItem == null) return;
            // получаем выделенный объект
            Worker worker = LViewWorkers.SelectedItem as Worker;

            WorkerWindow workWindow = new WorkerWindow(new Worker
            {
                id = worker.id,
                name = worker.name,
                login = worker.login,
                password = worker.password,
                position = worker.position,
                experience = worker.experience
            });
            workWindow.Show();

        }
        private async void BDelete_Click(object sender, RoutedEventArgs e)
        {
            // получаем выделенный объект
            Worker worker = LViewWorkers.SelectedItem as Worker;
            int id = worker.id;
            var client = new HttpClient();
            var uri = new Uri(String.Format("https://rostelekek.herokuapp.com/worker/" + id));
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var response = await client.DeleteAsync(uri);
            var json = response.Content.ReadAsStringAsync().Result;
            MessageBox.Show(json.ToString());
        }

        private async void BCreate_Click(object sender, RoutedEventArgs e)
        {
            WorkerWindow workWindow = new WorkerWindow(new Worker());
            workWindow.Show();

        }
        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            new LoginWindow().Show();
            Close();
        }

        private void BRestart_Click(object sender, RoutedEventArgs e)
        {
            new AdminWindow().Show();
            this.Close();
        }
    }
}
