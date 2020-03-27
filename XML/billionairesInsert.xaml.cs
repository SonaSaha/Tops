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
    /// Interaction logic for billionairesInsert.xaml
    /// </summary>
    public partial class billionairesInsert : Page
    {
        public billionairesInsert()
        {
            InitializeComponent();
        }

        private void insert(object sender, RoutedEventArgs e)
        {
            List<string> listForValues = new List<string>();

            listForValues.Add(Rank_.Text);
            listForValues.Add(Name_.Text);
            listForValues.Add(Age.Text);
            listForValues.Add(Net_worth.Text);
            listForValues.Add(Citizenship.Text);
            listForValues.Add(Main_source.Text);
            DAL.BillionairesManager obj = new DAL.BillionairesManager(listForValues);
            obj.insert();

        }
    }
}
