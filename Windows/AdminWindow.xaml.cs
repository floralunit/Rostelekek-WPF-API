using System;
using System.Collections.Generic;
using System.Linq;
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
        public AdminWindow()
        {
            InitializeComponent();
        }
        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BCreate_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            new LoginWindow().Show();
            Close();
        }
    }
}
