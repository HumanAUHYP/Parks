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
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
            tb_employee_name.Text = $"Здравствуйте, {Globals.employeeName}\nВаш график работы на сегодня:";
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            EmployeeMenu employeeMenu = new EmployeeMenu();
            employeeMenu.Show();
            Close();
        }
    }
}
