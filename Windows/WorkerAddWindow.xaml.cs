using Newtonsoft.Json;
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
    /// Логика взаимодействия для WorkerWindow.xaml
    /// </summary>
    public partial class WorkerAddWindow : Window
    {
        int id;
        public WorkerAddWindow(Worker w)
        {
            InitializeComponent();
            this.DataContext = w;
            if (w.name != null)
            {
                BEdit.Visibility = Visibility.Visible;
                id = w.id;
            }
            else
            {
                BCreate.Visibility = Visibility.Visible;
            }
        }

        private async void AcceptCreate_Click(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            var person = new Worker1();
            person.name = TBName.Text;
            person.password = TBPassword.Text;
            person.experience = TBExperience.Text;
            person.login = TBLogin.Text;
            if (CBPosition.SelectedItem == CBAdmin) person.position = "Администратор";
            if (CBPosition.SelectedItem == CBManager) person.position = "Диспетчер";
            if (CBPosition.SelectedItem == CBExecutor) person.position = "Исполнитель";

            var json1 = JsonConvert.SerializeObject(person);
            var data = new StringContent(json1, Encoding.UTF8, "application/json");
            HttpResponseMessage response = new HttpResponseMessage();

            var uri = new Uri("https://rostelekek.herokuapp.com/auth/register-worker");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            response = await client.PostAsync(uri, data);
            var json = response.Content.ReadAsStringAsync().Result;
            MessageBox.Show(json.ToString());
            Close();
        }
        private async void AcceptEdit_Click(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            var person = new Worker1();
            person.name = TBName.Text;
            person.password = TBPassword.Text;
            person.experience = TBExperience.Text;
            person.login = TBLogin.Text;
            if (CBPosition.SelectedItem == CBAdmin) person.position = "Администратор";
            if (CBPosition.SelectedItem == CBManager) person.position = "Диспетчер";
            if (CBPosition.SelectedItem == CBExecutor) person.position = "Исполнитель";

            var json1 = JsonConvert.SerializeObject(person);
            var data = new StringContent(json1, Encoding.UTF8, "application/json");
            HttpResponseMessage response = new HttpResponseMessage();
            var uri = new Uri(String.Format("https://rostelekek.herokuapp.com/worker/" + id));
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, uri)
            {
                Content = data
            };
            MessageBox.Show(request.ToString());
            response = await client.SendAsync(request);
            var json = response.Content.ReadAsStringAsync().Result;
            MessageBox.Show(json.ToString());
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
