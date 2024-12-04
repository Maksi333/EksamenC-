using BLL.BLL;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF.Windows
{
    /// <summary>
    /// Interaction logic for TimeManagement.xaml
    /// </summary>
    public partial class TimeManagement : Window
    {
        public ObservableCollection<Department> MyDepartments = new ObservableCollection<Department>();
        public ObservableCollection<Employee> MyEmployees = new ObservableCollection<Employee>();
        public ObservableCollection<Task> MyTasks = new ObservableCollection<Task>();
        public ObservableCollection<TimeRegistration> MyTimeRegs = new ObservableCollection<TimeRegistration>();
        public TimeManagement()
        {
            InitializeComponent();
            LoadDepartments();
            LoadEmployees();
            LoadTimeRegistrations();
        }

        private void LoadTimeRegistrations()
        {
            TimeList.DataContext = this;
            TimeList.ItemsSource = MyTimeRegs;
        }
        private void LoadEmployees()
        {
            EmpList.DataContext = this;
            EmpList.ItemsSource = MyEmployees;
        }

        private void LoadDepartments()
        {
            MyDepartments.Clear();
            List<Department> departments = DepartmentBll.GetAllDepartents();
            foreach (var dep in departments)
            {
                MyDepartments.Add(dep);
            }
            DepartmentsBox.ItemsSource = MyDepartments;
        }

        private void ViewEmpbtn_Click(object sender, RoutedEventArgs e)
        {
            MyEmployees.Clear();
            Department dep = (DTO.Model.Department)DepartmentsBox.SelectedItem;
            List<Employee> employees = EmployeeBll.GetAllEmployees();
            foreach (var emp in employees)
            {
                if (emp.DepNumber == dep.DepNumber)
                {
                    MyEmployees.Add(emp);
                }
            }
        }
        /*
        private void ViewTasksBtn_Click(object sender, RoutedEventArgs e)
        {
            MyTasks.Clear();
            Department dep = (DTO.Model.Department)DepartmentsBox.SelectedItem;
            List<Task> tasks = TaskBll.getAllTasks();
            foreach(var t in tasks)
            {
                if(dep.DepNumber == t.DepID)
                {
                    MyTasks.Add(t);
                }
            }
        }
        */

        private void ViewTimeBtn_Click(object sender, RoutedEventArgs e)
        {
            MyTimeRegs.Clear();
            Employee emp = (DTO.Model.Employee)EmpList.SelectedItem;
            List<TimeRegistration> timeRegs = EmployeeBll.GetTimeRegs(emp.Initials);
            foreach (var timeReg in timeRegs)
            {
                MyTimeRegs.Add(timeReg);
            }
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            DateTime start = DateTime.Parse(StartTimetxf.Text);
            DateTime end = DateTime.Parse(EndTimeTxf.Text);
            TimeRegistration selectedTimeReg = (DTO.Model.TimeRegistration)TimeList.SelectedItem;
            TimeRegBll.UpdateTimeReg(selectedTimeReg, start, end);
            
        }

        private void WorkTimeBtn_Click(object sender, RoutedEventArgs e)
        {
            TimeRegistration timeReg = (DTO.Model.TimeRegistration)TimeList.SelectedItem;
            DateTime start = timeReg.Start;
            DateTime end = timeReg.End;
            StartTimetxf.Text = start.ToString();
            EndTimeTxf.Text = end.ToString();
            this.Close();
        }
    }
}
