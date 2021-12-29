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
    /// Логика взаимодействия для StateWindow.xaml
    /// </summary>
    public partial class StateAddWindow : Window
    {
        int id;
        List<Work_Act> acts = new List<Work_Act>();
        public StateAddWindow(int _id)
        {
            InitializeComponent();
            id = _id;
        }
        private async void StateAddWindow_Loaded(object sender, RoutedEventArgs e)
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
            acts = pipa.Where(p => p.id == id).ToList();
            this.DataContext = acts;
        }
        private async void AcceptCreate_Click(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            var act = new Work_Act1();
            act.id_order = acts[0].id_order;
            act.id_worker = acts[0].id_worker;
            act.start_date = acts[0].start_date;
            act.state = TBState.Text;
            if (TBDate.Text != "")
            {
                act.finish_date = TBDate.Text;
                act.state = "Завершен";
            }
                 else act.finish_date = "2001-06-06";
            var json1 = JsonConvert.SerializeObject(act);
            var data = new StringContent(json1, Encoding.UTF8, "application/json");
            HttpResponseMessage response = new HttpResponseMessage();
            var uri = new Uri(String.Format("https://rostelekek.herokuapp.com/work-act/" + id));
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, uri)
            {
                Content = data
            };
            response = await client.SendAsync(request);
            var json = response.Content.ReadAsStringAsync().Result;
            MessageBox.Show(json.ToString());
            Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
