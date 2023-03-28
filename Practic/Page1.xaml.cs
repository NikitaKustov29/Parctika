using System;
using System.Collections.Generic;
using System.Data;
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
using Practic.practicaDataSetTableAdapters;

namespace Practic
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        zizkaTableAdapter zizka = new zizkaTableAdapter();
        public Page1()
        {
            InitializeComponent();
            ZizkaGrid.ItemsSource = zizka.GetData();
            ZizkaList.ItemsSource = zizka.GetData();
            ZizkaList.DisplayMemberPath = "mg";
        }

        private void ZizkaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show((ZizkaList.SelectedItem as DataRowView).Row[1].ToString());
        }
    }
}
