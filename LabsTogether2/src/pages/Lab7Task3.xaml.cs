using LabsTogether2.src.entities;
using System;
using System.Collections;
using System.Collections.Generic;
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
        //private Hashtable students;
        private List<Student> students;
        private List<LevelOfEducation> levelOfEducations;

        public Lab7Task3()
        {
            this.InitializeComponent();
            //students = new Hashtable
            //{
            //    { 1111, new Student() { FirstName = "Ivan", LastName = "Ivanov", Patronymic = "Ivanovich" } },
            //    { 1112, new Student() { FirstName = "Alex", LastName = "Ivanov", Patronymic = "Alexeevich" } }
            //};
            students = new List<Student>();
            levelOfEducations = Enum.GetValues(typeof(LevelOfEducation)).Cast<LevelOfEducation>().ToList();
            lvStudents.ItemsSource = students;
            students.Add(new Student("Ivan", "Ivanov", "Ivanovich", 1234, LevelOfEducation.Bachelor));
  
        }

        private void AddNewStudent(object sender, RoutedEventArgs e)
        { 
            students.Add(new Student(tbFN.Text, tbLN.Text,tbP.Text, Int32.Parse(tbPID.Text), (LevelOfEducation)cbLOE.SelectedItem));
        }
    }

    //public class Student
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Patronymic { get; set; }
    //}
}
