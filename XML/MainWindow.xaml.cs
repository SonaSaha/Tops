using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace SqlHomework1
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
        private void Click_button(object sender, RoutedEventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "(local)";
            builder.InitialCatalog = "The_Bests";
            builder.IntegratedSecurity = false;
            builder.UserID = name.Text;
            builder.Password = password.Password;

            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {

                conn.Open();
               
                
                SqlCommand cmd = new SqlCommand();
                
                cmd.Connection = conn;


                second0 second0 = new second0();
                second0.Show();
                this.Hide();

            }

        }
    }
}
