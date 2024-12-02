using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Windows;
using BLL;
using BLL.BLL;
using DTO.Model;
using System.Collections.ObjectModel;


namespace WPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public ObservableCollection<Employee> MyEmployees = new ObservableCollection<Employee>();
        public MainWindow() {
            InitializeComponent();
            ListOfStuff.DataContext = this;
            ListOfStuff.ItemsSource = MyEmployees;

        }

        private void NewEmpBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateEmployee createEmployee = new CreateEmployee();
            createEmployee.Show();
        }

        private void NewTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateTask createTask = new CreateTask();
            createTask.Show();
        }

        private void SeeEmployeesBtn_Click(object sender, RoutedEventArgs e)
        {
            //Todo Update ListBox to show all Employees and change label to "Emplyees"
            MyEmployees.Clear();
            List<Employee> employees = EmployeeBll.GetAllEmployees();
            foreach(var emp in employees)
            {
                MyEmployees.Add(emp);
            }
            ListLabel.Content = "Showing Employees";

        }

        private void ViewTasksBtn_Click(object sender, RoutedEventArgs e)
        {
            //Todo Update Listbox to show all Tasks And change label to "Tasks"
            ListLabel.Content = "Showing Tasks";
        }

        private void TestKnap_Click(object sender, RoutedEventArgs e)
        {
            TestLabel.Content = TaskBll.getTask(1).Title;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
