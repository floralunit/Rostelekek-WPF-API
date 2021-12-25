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
            var equip = new CreateEquipmentDto()
            {
                Name = TBName.Text,
                Price = Convert.ToDouble(TBPrice.Text),
                Notes = TBNotes.Text
            };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var httpClient = new HttpClient();
            var url = "https://rostelekek.herokuapp.com";
            var client = new EquipmentControllerClient(url, httpClient);
            var _equip = client.CreateAsync(equip);
            MessageBox.Show("Оборудование успешно добавлено");
            Close();
        }
        private async void AcceptEdit_Click(object sender, RoutedEventArgs e)
        {
            var equip = new UpdateEquipmentDto(){ 
                Name = TBName.Text,
                Price = Convert.ToDouble(TBPrice.Text),
                Notes = TBNotes.Text
            };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var httpClient = new HttpClient();
            var url = "https://rostelekek.herokuapp.com";
            var client = new EquipmentControllerClient(url, httpClient);
            var _equip = client.UpdateAsync(id, equip);
            MessageBox.Show("Информация успешно обновлена");
            Close();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
