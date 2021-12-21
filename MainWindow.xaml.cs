﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Rostelekek_WPF_API
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                tt_alphabet.Visibility = Visibility.Collapsed;
                tt_dictionary.Visibility = Visibility.Collapsed;
                tt_pharaon.Visibility = Visibility.Collapsed;
                tt_gods.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_alphabet.Visibility = Visibility.Visible;
                tt_dictionary.Visibility = Visibility.Visible;
                tt_pharaon.Visibility = Visibility.Visible;
                tt_gods.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            Frame.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LV_Alphabet_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Frame.Source = new Uri("/Pages/AlphabetPage.xaml", UriKind.Relative);
        }

        private void LV_DictionaryPage_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Frame.Source = new Uri("/Pages/DictionaryPage.xaml", UriKind.Relative);
        }

        private void LV_Pharaons_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Frame.Source = new Uri("/Pages/PharaonPage.xaml", UriKind.Relative);
        }

        private void LV_Gods_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Frame.Source = new Uri("/Pages/GodsPage.xaml", UriKind.Relative);
        }
        private void LV_Profile_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (App.CurrentUser == null)
            {
                MessageBox.Show("Для входа в личный кабинет вам нужно авторизоваться!");
                return;
            }
            else
            {
                //if (App.CurrentUser.RoleId == 1) Frame.Source = new Uri("/Pages/ProfileClientPage.xaml", UriKind.Relative);
                //else if (App.CurrentUser.RoleId == 2) Frame.Source = new Uri("/Pages/ProfileTranslatorPage.xaml", UriKind.Relative);
            }
        }
        private void LV_Exit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new LoginWindow().Show();
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
