using System;
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
using System.Windows.Shapes;

namespace Parks
{
    /// <summary>
    /// Логика взаимодействия для AddPlant.xaml
    /// </summary>
    public partial class AddPlant : Window
    {
        public AddPlant()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var save = new Plants();
                save.plant_name = tbx_name.Text;
                save.plant_age = tbx_age.Text;
                save.planting_date = dp_planting_date.SelectedDate;
                save.ID_species = 1;
                save.ID_watering = 1;

                db_connection.connection.Plants.Add(save);
                db_connection.connection.SaveChanges();
                MessageBox.Show("all ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка {ex}", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            Close();
        }
    }
}
