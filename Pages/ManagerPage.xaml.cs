using System;
using System.Collections.Generic;
using System.Linq;
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
        private async void BtnReg_Click(object sender, RoutedEventArgs e)
        {


            //// Account account = JsonConvert.DeserializeObject<Account>(json);
            //// james@example.com
            //var client = new HttpClient();
            //HttpResponseMessage response = new HttpResponseMessage();
            //var uri = new Uri("https://artartwebapp.herokuapp.com/event");
            //response = await client.GetAsync(uri);
            //string json = response.Content.ReadAsStringAsync().Result;
            //JArray o = JArray.Parse(json);
            //JArray ob = JArray.Parse(o[0].ToString());
            //var pipa = JsonConvert.DeserializeObject<List<Art>>(ob.ToString());
            //label.Content = pipa[1].description;
            //Console.WriteLine(pipa[1].description);
            ////var pupa = JsonConvert.DeserializeObject<Art>(pipa.MyArray[0]);
            ////label.Content = pupa.title;

        }
    }
}
