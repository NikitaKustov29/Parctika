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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        brandTableAdapter brands = new brandTableAdapter();
        public Page2()
        {
            InitializeComponent();
            BrandsGrid.ItemsSource = brands.GetData();
            BrandList.ItemsSource = brands.GetData();
            BrandList.DisplayMemberPath = "nameBrand";
        }

        private void BrandList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show((BrandList.SelectedItem as DataRowView).Row[1].ToString());
        }
    }
}
