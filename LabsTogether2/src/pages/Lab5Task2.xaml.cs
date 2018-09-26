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
using LabsTogether2.src.other;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace LabsTogether2.src.pages
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Lab5Task2 : Page
    {
        public Lab5Task2()
        {
            this.InitializeComponent();
        }


        private async void BtnCalculate_Click_Async(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Int32.Parse(tbN.Text);
                if (n <= 0) throw new ArgumentException();
                double sum = 0;
                for (int i = 1; i <= n; i++)
                    sum += 1 / Math.Pow(i, 2);
                tbS.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }
    }
}
