using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary>
    public partial class AppointEmployee : Window
    {
        public static ObservableCollection<Employee> employee { get; set; }
        public static ObservableCollection<Plants> plants { get; set; }
        public AppointEmployee()
        {
            InitializeComponent();

            employee = new ObservableCollection<Employee>(db_connection.connection.Employee.ToList());
            plants = new ObservableCollection<Plants>(db_connection.connection.Plants.ToList());
            this.DataContext = this;
        }

        private void employee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void plant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_appoint_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
