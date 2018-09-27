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
    public sealed partial class Lab6Task1 : Page
    {
        public Lab6Task1()
        {
            this.InitializeComponent();
        }

        private void BtnAddElement_Click(object sender, RoutedEventArgs e)
        {
            vswGridElements.Children.Add(new TextBox());
        }

        private async void BtnFind_Click_Async(object sender, RoutedEventArgs e)
        {
            try
            {
                var minValue = vswGridElements.Children.OfType<TextBox>().Min(s => Double.Parse(s.Text));
                tblMinElement.Text = minValue.ToString() + ", " +
                   (vswGridElements.Children.IndexOf(
                       vswGridElements.Children.OfType<TextBox>().First(a => a.Text == minValue.ToString())
                       ) + 1)
                       .ToString();

                var maxValue = vswGridElements.Children.OfType<TextBox>().Max(s => Double.Parse(s.Text));
                tblMaxElement.Text = maxValue.ToString() + ", " +
                   (vswGridElements.Children.IndexOf(
                       vswGridElements.Children.OfType<TextBox>().First(a => a.Text == maxValue.ToString())
                       ) + 1)
                       .ToString();
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }
    }
}
