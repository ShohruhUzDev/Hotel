using Hotel_interfeys.UserControls;
using Itenso.TimePeriod;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

namespace Hotel_interfeys
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable dt = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
            dt.Columns.Add("Iyun");
            dt.Columns.Add("Iyul");
            dt.Columns.Add("Avgust");
            dt.Columns.Add("Sentabr");
            dt.Columns.Add("Oktabr");
            dt.Columns.Add("Noyabr");
            dt.Columns.Add("Dekabr");
            dt.Columns.Add("Yanvar");
            dt.Columns.Add("Fevral");
        }
         
            private void Window_Loaded(object sender, RoutedEventArgs e)
             {
           

            }

        private void maximize_btn_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {

                this.WindowState = WindowState.Maximized;
                maximize_icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowRestore;
            }
            else

            {
                maximize_icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowMaximize;
                this.WindowState = WindowState.Normal;
            }

        }

        private void minimize_btn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Registration_btn_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Rooms_Click(object sender, RoutedEventArgs e)
        {
            Rooms rooms = new Rooms();
            asosiy_oyna_grid.Children.Add(rooms);
        }

        private void Guests_btn_Click(object sender, RoutedEventArgs e)
        {
            Guests guests = new Guests();
            asosiy_oyna_grid.Children.Add(guests);
        }

        private void Emoloyee_btn_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            asosiy_oyna_grid.Children.Add(employee);
        }
    }
    
}
