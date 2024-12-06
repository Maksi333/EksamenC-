using BLL.BLL;
using DTO.Model;
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

namespace WPF.Windows
{
    /// <summary>
    /// Interaction logic for CreateTask.xaml
    /// </summary>
    public partial class CreateTask : Window
    {
        public ObservableCollection<Department> MyDepartments = new ObservableCollection<Department>();
        public CreateTask()
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
            DepBox.ItemsSource = MyDepartments;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(titletxf == null || desctxf == null || DepBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            /*if(!int.TryParse(idtxf.Text, out int id)){
                MessageBox.Show("Please use number for ID");
                return;
            }
            */
            Department dep = (DTO.Model.Department)DepBox.SelectedItem;
            TaskBll.CreateTask(1, titletxf.Text, desctxf.Text, dep.DepNumber);
            this.Close();
        }

    }
}
