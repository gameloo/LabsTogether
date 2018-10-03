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
    public sealed partial class Lab8 : Page
    {
        public Lab8()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var a = Double.Parse(tbA.Text);
                var b = Double.Parse(tbB.Text);
                var u = Min(a, b - a);
                var v = Min(a * b, a + b);
                var k = Min(u + v * 2, 3.14);
                tblU.Text = "u: " + u;
                tblV.Text = "v: " + v;
                tblK.Text = "k: " + k;
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }

        private static double Min(double x, double y)
        {
            if (x < y) return x;
            else return y;
        }
    }
}
