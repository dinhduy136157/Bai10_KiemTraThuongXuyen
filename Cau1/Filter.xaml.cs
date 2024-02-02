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

namespace Cau1
{
    /// <summary>
    /// Interaction logic for Filter.xaml
    /// </summary>
    public partial class Filter : Window
    {
        private List<Employee> employees;
        public Filter(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgvEmployeeInfo.ItemsSource = employees;
        }
    }
}
