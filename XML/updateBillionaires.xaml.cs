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
    /// Interaction logic for updateBillionaires.xaml
    /// </summary>
    public partial class updateBillionaires : Page
    {
        public updateBillionaires()
        {
            InitializeComponent();
        }
      
        private void Update(object sender, RoutedEventArgs e)
        {
            List<string> listForValues = new List<string>();
            
            listForValues.Add(Rank_.Text);
            listForValues.Add(Name_.Text);
            listForValues.Add(Age.Text);
            listForValues.Add(Net_worth.Text);
            listForValues.Add(Citizenship.Text);
            listForValues.Add(Main_source.Text);
            DAL.BillionairesManager obj = new DAL.BillionairesManager(listForValues);
            DAL.BillionairesManager obj1 = new DAL.BillionairesManager(column.Text, condition.Text);
            obj.update();
        }
        private void Show(object sender, RoutedEventArgs e)
        {
            DAL.BillionairesManager obj = new DAL.BillionairesManager();
            table.ItemsSource = obj.selectAllTable().DefaultView;
        }
    }
}
