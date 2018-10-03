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
        private Hashtable students;

        public Lab7Task3()
        {
            this.InitializeComponent();
            students = new Hashtable
            {
                { 1111, new Student() { FirstName = "Ivan", LastName = "Ivanov", Patronymic = "Ivanovich" } },
                { 1112, new Student() { FirstName = "Alex", LastName = "Ivanov", Patronymic = "Alexeevich" } }
            };
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
    }
}
