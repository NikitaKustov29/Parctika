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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        zizkaTableAdapter zizka = new zizkaTableAdapter();    
        public Page1()
        {
            InitializeComponent();
            ZizkaGrid.ItemsSource = zizka.GetData();
            IdsBox.ItemsSource = zizka.GetData();
            IdsBox.DisplayMemberPath = "id";
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IdsBox.SelectedIndex != -1)
            {
                int id = zizka.GetData()[IdsBox.SelectedIndex].id;
                zizka.DeleteQuery(id, id);
                IdsBox.ItemsSource = zizka.GetData();
                ZizkaGrid.ItemsSource = zizka.GetData();
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {

            if (UpdateZiBx.Text != null && UpdateMgBx.Text != null)
            {

                zizka.UpdateQuery(UpdateZiBx.Text, Convert.ToInt32(UpdateMgBx.Text), Convert.ToInt32((ZizkaGrid.SelectedItem as DataRowView).Row[0]));
                ZizkaGrid.ItemsSource = zizka.GetData();
            }
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            if (InsertZiBx.Text != null && InsertMgBx.Text != null)
            {
                zizka.InsertQuery(InsertZiBx.Text, Convert.ToInt32(InsertMgBx.Text));
                ZizkaGrid.ItemsSource = zizka.GetData();
            }
        }

        private void ZizkaGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if ((ZizkaGrid.SelectedItem as DataRowView) != null)
            {
                UpdateZiBx.Text = (ZizkaGrid.SelectedItem as DataRowView).Row[1].ToString();
                UpdateMgBx.Text = (ZizkaGrid.SelectedItem as DataRowView).Row[2].ToString();
            }
        }
    }
}
