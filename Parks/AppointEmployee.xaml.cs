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
        public static ObservableCollection<WorkSchedule> workSchedules { get; set; }

        int employee_id { get; set; }
        int plant_id { get; set; }
        public AppointEmployee()
        {
            InitializeComponent();

            employee = new ObservableCollection<Employee>(db_connection.connection.Employee.ToList());
            plants = new ObservableCollection<Plants>(db_connection.connection.Plants.ToList());
            this.DataContext = this;
        }

        private void employee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ListView).SelectedItem as Employee;
            employee_id = a.ID_employee;
        }

        private void plant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ListView).SelectedItem as Plants;
            plant_id = a.ID_plant;
        }

        private void btn_appoint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var save = new WorkSchedule();
                save.date = dp_date.SelectedDate;
                save.ID_employee = employee_id;
                save.ID_plant = plant_id;

                db_connection.connection.WorkSchedule.Add(save);
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

        private void btn_delete_employee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"Сотрудник удален");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_delete_plant_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"Насаждение удалено");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
