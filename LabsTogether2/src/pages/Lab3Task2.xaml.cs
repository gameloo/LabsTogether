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
    public sealed partial class Lab3Task2 : Page
    {
        public Lab3Task2()
        {
            this.InitializeComponent();
        }

        private async void BtnCalculate_ClickAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Double.Parse(tbX.Text);
                if ((x > 1) && (x < 2)) tbY.Text = Math.Pow(Math.Cos(x), 2).ToString();
                else tbY.Text = (1 + Math.Pow(Math.Sin(x), 2)).ToString();
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }
    }
}
