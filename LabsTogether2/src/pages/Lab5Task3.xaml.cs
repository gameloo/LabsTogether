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
    public sealed partial class Lab5Task3 : Page
    {
        public Lab5Task3()
        {
            this.InitializeComponent();
        }

        private async void BtnCalculate_Click_Async(object sender, RoutedEventArgs e)
        {
            try
            {
                double eps = Double.Parse(tbEps.Text);
                if (eps <= 0) throw new ArgumentException();
                tbS.Text = CalculateTask3(1, eps).ToString();
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }

        private static int Counter = 0;
        private static double CalculateTask3(double number, double eps)
        {
            Counter++;
            double tempNum = number * 1 / Math.Sqrt(Counter);
            if (tempNum >= eps)
                return tempNum + CalculateTask3(tempNum, eps);
            else
            {
                Counter = 0;
                return tempNum;
            }
        }
    }
}
