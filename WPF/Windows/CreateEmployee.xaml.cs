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
using BLL.BLL;
using DTO.Model;

namespace WPF.Windows
{
    /// <summary>
    /// Interaction logic for CreateEmployee.xaml
    /// </summary>
    //
    public partial class CreateEmployee : Window
    {
        public ObservableCollection<Department> MyDepartments = new ObservableCollection<Department>();
        public CreateEmployee()
        {
            InitializeComponent();
            LoadDepartments();
        }
        private void LoadDepartments()
        {
            MyDepartments.Clear();
            List<Department> departments = DepartmentBll.GetAllDepartents();
            foreach (var dep in departments)
            {
                MyDepartments.Add(dep);
            }
            DepartmentList.ItemsSource = MyDepartments;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Department selectedDep = (DTO.Model.Department)DepartmentList.SelectionBoxItem;
            EmployeeBll.CreateEmployee(Inittxf.Text, Int32.Parse(Cprtxf.Text), Nametxf.Text, selectedDep.DepNumber); 
            this.Close();
        }
        
    }
}
