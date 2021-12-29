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
using System.Windows.Threading;

namespace Rostelekek_WPF_API.Windows
{
    /// <summary>
    /// Логика взаимодействия для EquipWindow.xaml
    /// </summary>
    public partial class EquipAddWindow : Window
    {
        int id;
        public EquipAddWindow(int _id)
        {
            InitializeComponent();
            id = _id;
            if (id != -1)
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var httpClient = new HttpClient();
                var url = "https://rostelekek.herokuapp.com";
                var client = new EquipmentControllerClient(url, httpClient);
                var equip = client.FindOneAsync(id).Result;
                this.DataContext = equip;
                BEdit.Visibility = Visibility.Visible;
            }
            else
            {
                BCreate.Visibility = Visibility.Visible;
            }


        }

        private async void AcceptCreate_Click(object sender, RoutedEventArgs e)
        {
            //var equip = new CreateEquipmentDto()
            //{
            //    Name = TBName.Text,
            //    Price = Convert.ToDouble(TBPrice.Text),
            //    Notes = TBNotes.Text
            //};
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //var httpClient = new HttpClient();
            //var url = "https://rostelekek.herokuapp.com";
            //var client = new EquipmentControllerClient(url, httpClient);
            //var _equip = client.CreateAsync(equip);
            //MessageBox.Show("Оборудование успешно добавлено");
            //Close();
            var client = new HttpClient();
            var equip = new Equip1();
            equip.name = TBName.Text;
            equip.price = Convert.ToInt32(TBPrice.Text);
            equip.notes = TBNotes.Text;

            var json1 = JsonConvert.SerializeObject(equip);
            var data = new StringContent(json1, Encoding.UTF8, "application/json");
            HttpResponseMessage response = new HttpResponseMessage();

            var uri = new Uri("https://rostelekek.herokuapp.com/equipment");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            response = await client.PostAsync(uri, data);
            var json = response.Content.ReadAsStringAsync().Result;
            MessageBox.Show(json.ToString());
            Close();
        }
        private async void AcceptEdit_Click(object sender, RoutedEventArgs e)
        {
            //var equip = new UpdateEquipmentDto()
            //{
            //    Name = TBName.Text,
            //    Price = Convert.ToDouble(TBPrice.Text),
            //    Notes = TBNotes.Text
            //};
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //var httpClient = new HttpClient();
            //var url = "https://rostelekek.herokuapp.com";
            //var client = new EquipmentControllerClient(url, httpClient);
            //var _equip = client.UpdateAsync(id, equip);
            //MessageBox.Show("Информация успешно обновлена");
            //Close();
            var client = new HttpClient();
            var equip = new Equip1();
            equip.name = TBName.Text;
            equip.price = Convert.ToInt32(TBPrice.Text);
            equip.notes = TBNotes.Text;

            var json1 = JsonConvert.SerializeObject(equip);
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
