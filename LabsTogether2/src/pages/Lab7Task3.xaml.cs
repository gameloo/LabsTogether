using LabsTogether2.src.entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace LabsTogether2.src.pages
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Lab7Task3 : Page
    {
        private ObservableCollection<Student> studentsResponse;
        private Hashtable students;

        public Lab7Task3()
        {
            this.InitializeComponent();
            students = new Hashtable
            {
                { 123456, new Student("Иван", "Иванов", "Иванович", 12345, LevelOfEducation.Bachelor) },
                { 123457, new Student("Артем", "Иванов", "Иванович", 12345, LevelOfEducation.Bachelor) },
                { 123458, new Student("Лидия", "Иванова", "Иванович", 12345, LevelOfEducation.Bachelor) },
                { 123459, new Student("Артем", "Кузнецов", "Иванович", 12345, LevelOfEducation.Bachelor) },
                { 123450, new Student("Степан", "Студентов", "Иванович", 12345, LevelOfEducation.Bachelor) },
                { 123451, new Student("Степан", "Иванов", "Иванович", 12345, LevelOfEducation.Bachelor) },
                { 123452, new Student("Артем", "Логвинов", "Иванович", 12345, LevelOfEducation.Bachelor) }
            };
            studentsResponse = new ObservableCollection<Student>();

        }

        private async void FindStudent(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedStudents = from t in students.Values.OfType<Student>().ToList()
                                       where t.LastName == tbLN.Text
                                       select t;
                studentsResponse = new ObservableCollection<Student>(selectedStudents);
                lvStudents.ItemsSource = studentsResponse;
                lvStudents.UpdateLayout();
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }
    }
}
