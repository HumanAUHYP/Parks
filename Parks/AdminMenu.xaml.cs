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
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btn_addPlant_Click(object sender, RoutedEventArgs e)
        {
            AddPlant addPlant = new AddPlant();
            addPlant.Show();
            Close();
        }

        private void btn_addEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            Close();
        }

        private void btn_appointEmployee_Click(object sender, RoutedEventArgs e)
        {
            AppointEmployee appointEmployee = new AppointEmployee();
            appointEmployee.Show();
            Close();
        }
    }
}
