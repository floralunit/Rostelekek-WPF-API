using Newtonsoft.Json;
using Rostelekek_WPF_API;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rostelekek_WPF_API
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    
    public class Equip : INotifyPropertyChanged
    {
        private string _name { get; set; }
        private string _price { get; set; }
        private string _notes { get; set; }
        public int id { get; set; }
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("name"));
            }
        }
        public string price
        {
            get { return _price; }
            set
            {
                 _price = value;
                OnPropertyChanged(new PropertyChangedEventArgs("price"));
            }
        }
        public string notes
        {
            get { return _notes; }
            set
            {
                _notes = value;
                OnPropertyChanged(new PropertyChangedEventArgs("notes"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
    public class Request
    {
        public string statusCode { get; set; }
        public string message { get; set; }
        public string error { get; set; }
    }
    public class Worker :INotifyPropertyChanged
    {
        private string _login { get; set; }
        private string _password { get; set; }
        private string _name { get; set; }
        private string _position { get; set; }
        private string _experience { get; set; }
        public int id { get; set; }
        public string login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged(new PropertyChangedEventArgs("login"));
            }
        }
        public string password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(new PropertyChangedEventArgs("password"));
            }
        }
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("name"));
            }
        }
        public string experience
        {
            get { return _experience; }
            set
            {
                _experience = value;
                OnPropertyChanged(new PropertyChangedEventArgs("experience"));
            }
        }
        public string position
        {
            get { return _position; }
            set
            {
                _position = value;
                OnPropertyChanged(new PropertyChangedEventArgs("position"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
    
    class Worker1 :INotifyPropertyChanged
    {
        private string _login { get; set; }
        private string _password { get; set; }
        private string _name { get; set; }
        private string _position { get; set; }
        private string _experience { get; set; }
        public string login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged(new PropertyChangedEventArgs("login"));
            }
        }
        public string password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(new PropertyChangedEventArgs("password"));
            }
        }
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("name"));
            }
        }
        public string experience
        {
            get { return _experience; }
            set
            {
                _experience = value;
                OnPropertyChanged(new PropertyChangedEventArgs("experience"));
            }
        }
        public string position
        {
            get { return _position; }
            set
            {
                _position = value;
                OnPropertyChanged(new PropertyChangedEventArgs("position"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
