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
using AddData.practicaDataSetTableAdapters;

namespace AddData
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        brandTableAdapter brands = new brandTableAdapter();
        zizkaTableAdapter zizka = new zizkaTableAdapter();
        public Page2()
        {
            InitializeComponent();
            BrandGrid.ItemsSource = brands.GetData();
            InsertZiBx.ItemsSource = zizka.GetData();
            UpdateZiBx.ItemsSource = zizka.GetData();
            IdsBox.ItemsSource = brands.GetData();

            IdsBox.DisplayMemberPath = "id";
            InsertZiBx.DisplayMemberPath = "nameZizka";
            UpdateZiBx.DisplayMemberPath = "nameZizka";
        }

        private void BrandGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if ((BrandGrid.SelectedItem as DataRowView) != null)
            {
                UpdateBrBx.Text = (BrandGrid.SelectedItem as DataRowView).Row[1].ToString();
            }
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            if (InsertBrBx.Text != null && InsertZiBx.SelectedIndex != -1)
            {
                int id = zizka.GetData()[InsertZiBx.SelectedIndex].id;
                brands.InsertQuery(InsertBrBx.Text, id);

                BrandGrid.ItemsSource = brands.GetData();
                IdsBox.ItemsSource = brands.GetData();
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UpdateBrBx.Text != null && UpdateZiBx.SelectedIndex != -1)
            {
                int idZizk = zizka.GetData()[UpdateZiBx.SelectedIndex].id;
                brands.UpdateQuery(UpdateBrBx.Text, idZizk, Convert.ToInt32((BrandGrid.SelectedItem as DataRowView).Row[0]));

                BrandGrid.ItemsSource = brands.GetData();
                InsertZiBx.ItemsSource = zizka.GetData();
                UpdateZiBx.ItemsSource = zizka.GetData();
                IdsBox.ItemsSource = brands.GetData();
            }
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IdsBox.SelectedIndex != -1)
            {
                int id = brands.GetData()[IdsBox.SelectedIndex].id;
                brands.DeleteQuery(id);
                IdsBox.ItemsSource = brands.GetData();
                BrandGrid.ItemsSource = brands.GetData();
            }
        }
    }
}
