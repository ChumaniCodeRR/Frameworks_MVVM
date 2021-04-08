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
using WPF_MVVM_Frameworks.Model;
using WPF_MVVM_Frameworks.ViewModel;
using WPF_MVVM_Frameworks.View.Partial;

namespace WPF_MVVM_Frameworks.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        MainPageViewModel mainPageViewModel = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            ListBoxSort.SelectedIndex = 0;
            StudentsDataGrid.ItemsSource = mainPageViewModel.GetStudents();
            CoursesListBox.ItemsSource = new AddPageViewModel().GetCourses();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var host = new Window();
            host.Content = new AddPage();
            host.ShowDialog();
        }

        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {
            Student student = (Student)StudentsDataGrid.SelectedItem;

            if (student != null)
            {
                var host = new Window();
                host.Content = new ModifyPage(student.StudentId);
                host.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pick a list");
            }
        }

        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            StudentsDataGrid.ItemsSource = mainPageViewModel.GetStudents();
        }

        private void ListBoxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StudentsDataGrid.ItemsSource = mainPageViewModel.GetStudentsSorted(ListBoxSort.Text);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Student student = (Student)StudentsDataGrid.SelectedItem;

            if (student != null)
            {
                DeletedPageViewModel deletedPageViewModel = new DeletedPageViewModel();
                var deletedStudentStatus = deletedPageViewModel.DeleteStudent(student.StudentId);
                MessageBox.Show("Student is deleted !!");
                StudentsDataGrid.ItemsSource = mainPageViewModel.GetStudents();
            }
            else
            {
                MessageBox.Show("Record was has not been deleted !!");
            }
        }

        private void CoursesSortButton_Click(object sender, RoutedEventArgs e)
        {
            var host = new Window();
            host.Content = new SortWithCourses();
            host.ShowDialog();
        }

        private void SortWithCoursesButton_Click(object sender, RoutedEventArgs e)
        {
            var Courses = new List<Course>();

            foreach (Course course in CoursesListBox.SelectedItems)
            {
                Courses.Add(course);
            }

            foreach (var item in mainPageViewModel.SortStudentsWithCourses(Courses))
            {
                StudentsDataGrid.ItemsSource = item.Students;
            }

        }
    }
}
