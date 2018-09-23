using System;
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
    public sealed partial class Lab2 : Page
    {
        private Random random;

        public Lab2()
        {
            this.InitializeComponent();
            random = new Random();
        }

        private void BtnRabdomize_Click(object sender, RoutedEventArgs e)
        {
            a1.Text = random.Next(100).ToString();
            a2.Text = random.Next(100).ToString();
            a3.Text = random.Next(100).ToString();
            a4.Text = random.Next(100).ToString();
            a5.Text = random.Next(100).ToString();
            a6.Text = random.Next(100).ToString();
            a7.Text = random.Next(100).ToString();
            a8.Text = random.Next(100).ToString();
            a9.Text = random.Next(100).ToString();
        }
    }
}
