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
        public ObservableCollection<Department> MyDepartments = new ObservableCollection<Department>();
        public ObservableCollection<Task> MyTasks = new ObservableCollection<Task>();
        public MainWindow() {
            InitializeComponent();
            LoadEmployees();
            LoadDepartments();
            LoadTasks();
        }

        private void LoadTasks()
        {
            TaskList.DataContext = this;
            TaskList.ItemsSource = MyTasks;
        }

        private void LoadEmployees()
        {
            ListOfEmployees.DataContext = this;
            ListOfEmployees.ItemsSource = MyEmployees;
        }

        private void LoadDepartments()
        {
            MyDepartments.Clear();
            List<Department> departments =  DepartmentBll.GetAllDepartents();
            foreach (var dep in departments)
            {
                MyDepartments.Add(dep);
            }
            DepartmentsDropDown.ItemsSource = MyDepartments;
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
            Department dep = (DTO.Model.Department)DepartmentsDropDown.SelectedItem;
            List<Employee> employees = EmployeeBll.GetAllEmployees();
            if(dep == null)
            {
                MessageBox.Show("Please select department");
            }
            else
            {
                foreach (var emp in employees)
                {
                    if (emp.DepNumber == dep.DepNumber)
                    {
                        MyEmployees.Add(emp);
                    }
                }
            }
        }

        private void ViewTasksBtn_Click(object sender, RoutedEventArgs e)
        {
            //Todo Update Listbox to show all Tasks And change label to "Tasks"
            MyTasks.Clear();
            Department dep = (DTO.Model.Department)DepartmentsDropDown.SelectedItem;
            List<Task> tasks = TaskBll.getAllTasks();
            if(dep == null)
            {
                MessageBox.Show("Please select department");
            }else
            {
                foreach (var task in tasks)
                {
                    if (dep.DepNumber == task.DepID)
                    {
                        MyTasks.Add(task);
                    }
                }
            }
            
        }

        private void ViewTime_Click(object sender, RoutedEventArgs e)
        {
            Employee selectedEmp = (DTO.Model.Employee)ListOfEmployees.SelectedItem;
            if(selectedEmp == null)
            {
                MessageBox.Show("Please select employee");
            }
            else
            {
                HoursWeek.Content =  System.Math.Round(EmployeeBll.GetHoursWeek(selectedEmp.Initials), 2);
                Hoursmonth.Content = System.Math.Round(EmployeeBll.GetHoursMonth(selectedEmp.Initials), 2);
                HoursTotal.Content = System.Math.Round(EmployeeBll.GetHoursTotal(selectedEmp.Initials), 2);
            }
        }

        private void EditTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            TimeManagement timeManagement = new TimeManagement();
            timeManagement.Show();
        }
    }
}
