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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cau1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Employee> employees = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new() { Code = txtCode.Text, FullName = txtFullName.Text, BirthDate = dpkBirthDate.SelectedDate.Value, Gender = rbnMale.IsChecked.Value ? "Nam" : "Nữ", DepartmentName = cboDepartmentName.Text, Salary = Convert.ToDecimal(txtSalary.Text) };
            employees.Add(employee);
            dgvEmployeeInfo.ItemsSource = employees;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dpkBirthDate.SelectedDate = DateTime.Today;
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            decimal maxSalary = employees.Max(em => em.Salary);
            List<Employee> maxEmployees = employees.Where(em => em.Salary == maxSalary).ToList(); 
            /*var maxEmployees = from employee in employees
                               where employee.Salary == maxSalary
                               select employee; */
            new Filter(maxEmployees.ToList()).ShowDialog();
        }
    }
}
