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
    /// Логика взаимодействия для WorkerWindow.xaml
    /// </summary>
    public partial class WorkerWindow : Window
    {
        public WorkerWindow()
        {
            InitializeComponent();
        }

        private async void WorkerWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var client = new HttpClient();
                HttpResponseMessage response = new HttpResponseMessage();
                var uri = new Uri("https://rostelekek.herokuapp.com/work-act");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                response = await client.GetAsync(uri);
                string json = response.Content.ReadAsStringAsync().Result;
                JArray o = JArray.Parse(json);
                JArray ob = JArray.Parse(o.ToString());
                var pipa = JsonConvert.DeserializeObject<List<Work_Act>>(ob.ToString());
                activeList.ItemsSource = pipa.Where(p => p.state != "Завершен" && p.id_worker==1).ToList();

                var pipa1 = JsonConvert.DeserializeObject<List<Work_Act>>(ob.ToString());
                doneList.ItemsSource = pipa1.Where(p => p.state == "Завершен" && p.id_worker == 1).ToList();
                label.Content = String.Format("Заказ-наряды для исполнителя № " + pipa1[0].id_worker);
            }
            catch
            {
                MessageBox.Show("Данные отсутствуют");
            }
            

        }

        private async void BEdit_Click(object sender, RoutedEventArgs e)
        {
            if (activeList.SelectedItem == null) return;
            // получаем выделенный объект
            Work_Act act = activeList.SelectedItem as Work_Act;
            StateAddWindow actWindow = new StateAddWindow(act.id);
            actWindow.Show();
        }
        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            new LoginWindow().Show();
            Close();
        }

        private void BRestart_Click(object sender, RoutedEventArgs e)
        {
            new WorkerWindow().Show();
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
