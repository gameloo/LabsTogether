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
        private ObservableCollection<Student> students;
        private List<LevelOfEducation> levelOfEducations;

        public Lab7Task3()
        {
            this.InitializeComponent();
            students = new ObservableCollection<Student>();
            levelOfEducations = Enum.GetValues(typeof(LevelOfEducation)).Cast<LevelOfEducation>().ToList();
            
        }

        private async void AddNewStudent(object sender, RoutedEventArgs e)
        {
            try
            {
                students.Add(new Student(tbFN.Text, tbLN.Text, tbP.Text, Int32.Parse(tbPID.Text), (LevelOfEducation)cbLOE.SelectedItem));
                lvStudents.UpdateLayout();
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }

        private void RemoveStudent(object sender, RoutedEventArgs e)
        {
            students.Remove((Student)lvStudents.SelectedItem);
        }
    }
}
