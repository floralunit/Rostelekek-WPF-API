using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rostelekek_WPF_API.Windows;
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

namespace Rostelekek_WPF_API.Pages
{
    /// <summary>
    /// Логика взаимодействия для EquipPage.xaml
    /// </summary>
    public partial class EquipPage : Page
    {
        public EquipPage()
        {
            InitializeComponent();

        }
        private async void EquipPage_Loaded(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            var uri = new Uri("https://rostelekek.herokuapp.com/equipment");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            response = await client.GetAsync(uri);
            string json = response.Content.ReadAsStringAsync().Result;
            JArray o = JArray.Parse(json);
            JArray ob = JArray.Parse(o.ToString());
            var pipa = JsonConvert.DeserializeObject<List<Equip>>(ob.ToString());
            equipList.ItemsSource = pipa.ToList();

        }
        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            if (equipList.SelectedItem == null) return;
            // получаем выделенный объект
            Equip equip = equipList.SelectedItem as Equip;

            EquipWindow equipWindow = new EquipWindow(equip.id);
            equipWindow.Show();


        }
        private async void BDelete_Click(object sender, RoutedEventArgs e)
        {
            if (equipList.SelectedIndex == null) return;
            // получаем выделенный объект
            Equip equip = equipList.SelectedItem as Equip;
            int id = equip.id;
            var client = new HttpClient();
            var uri = new Uri(String.Format("https://rostelekek.herokuapp.com/equipment/" + id));
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var response = await client.DeleteAsync(uri);
            var json = response.Content.ReadAsStringAsync().Result;
            MessageBox.Show(json.ToString());
        }

        private async void BCreate_Click(object sender, RoutedEventArgs e)
        {
            EquipWindow equipWindow = new EquipWindow(-1);
            equipWindow.Show();

        }
    }
    }
