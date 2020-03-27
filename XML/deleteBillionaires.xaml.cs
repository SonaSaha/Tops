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

namespace SqlHomework1
{
    /// <summary>
    /// Interaction logic for deleteBillionaires.xaml
    /// </summary>
    public partial class deleteBillionaires : Page
    {
        DAL.BillionairesManager obj = new DAL.BillionairesManager();
        public deleteBillionaires()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

           
            obj.conditionObj.field_= condition.Text;
            obj.delete();
        }

        private void Show(object sender, RoutedEventArgs e)
        {
            
            string tableName = second.tableFlag;
            txt.ItemsSource = obj.selectAllTable().DefaultView;
        }
    }
}
