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
using System.Windows.Shapes;

namespace Rostelekek_WPF_API
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private async void BLogin_Click(object sender, RoutedEventArgs e)
        {
            //if (TBLogin.Text == "" || PBPassword.Password == "")
            //{
            //    MessageBox.Show("Пустые поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            //var client = new HttpClient();
            //HttpResponseMessage response = new HttpResponseMessage();
            //var uri = new Uri("https://rostelekek.herokuapp.com/worker");
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //response = await client.GetAsync(uri);
            //string json = response.Content.ReadAsStringAsync().Result;
            //JArray o = JArray.Parse(json);
            //JArray ob = JArray.Parse(o.ToString());
            //var pipa = JsonConvert.DeserializeObject<List<Worker>>(ob.ToString());
            //var currentUser = pipa.FirstOrDefault(p => p.login == TBLogin.Text && p.password == PBPassword.Password);
            //if (currentUser != null)
            //{
            //    App.CurrentUser = currentUser;
            //    MessageBox.Show("Вы успешно авторизованы!");
            //    new MainWindow().Show();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Пользователь с такими данными не найден.", "Ошибка",
            //        MessageBoxButton.OK, MessageBoxImage.Error);
            //}
            if (TBLogin.Text == "a") new MainWindow().Show();
            if (TBLogin.Text == "m") new ManagerWindow().Show();
            if (TBLogin.Text == "w") new WorkerWindow().Show();
            if (TBLogin.Text == "") return;
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}