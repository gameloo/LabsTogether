using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
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
    public sealed partial class Lab1Task1 : Page
    {
        public Lab1Task1()
        {
            this.InitializeComponent();
        }

        private async void BtnCalculate_ClickAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Double.Parse(tbX.Text);
                double y = Double.Parse(tbY.Text);
                double z = Double.Parse(tbZ.Text);
                tbA.Text = Math.Log10(
                (y - Math.Sqrt(Math.Abs(x))) *
                (x - y / (z + Math.Pow(x, 2) / 4))
                ).ToString();
            }
            catch (FormatException ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }   
        }

        private void BeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            
            if (!Regex.IsMatch(args.NewText, @"^-?\d+,?\d{0,}$") && (sender.Text != ""))
            {
                sender.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);   
            }
            else sender.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
        }

       
    }
}
