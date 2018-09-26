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
    public sealed partial class Lab5Task4 : Page
    {
        public Lab5Task4()
        {
            this.InitializeComponent();
        }

        private async void BtnCalculate_Click_Async(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(tbNumber.Text, @"^\d+$")) throw new ArgumentException();
                if (!Regex.IsMatch(tbNumeral.Text, @"^\d{1}$")) throw new ArgumentException();

                tblCount.Text = new Regex(tbNumeral.Text).Matches(tbNumber.Text).Count.ToString();
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }
    }
}
