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
    /// Логика взаимодействия для EmployeeMenu.xaml
    /// </summary>
    public partial class EmployeeMenu : Window
    {
        public static ObservableCollection<Employee> employee { get; set; }

        int employee_id { get; set; }

        public EmployeeMenu()
        {
            InitializeComponent();
            employee = new ObservableCollection<Employee>(db_connection.connection.Employee.ToList());
            this.DataContext = this;
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void employees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ListView).SelectedItem as Employee;
            employee_id = a.ID_employee;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var emp = employee.Where(a => a.ID_employee == employee_id).FirstOrDefault();
            Globals.employeeName = emp.FIO;

            EmployeeWindow employeeWindow = new EmployeeWindow();
            employeeWindow.Show();
            Close();
        }
    }
}

