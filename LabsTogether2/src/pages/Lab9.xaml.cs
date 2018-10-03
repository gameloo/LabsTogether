using LabsTogether2.src.other;
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
    public sealed partial class Lab9 : Page
    {
        private Triangle objTriangle;

        public Lab9()
        {
            this.InitializeComponent();
            objTriangle = new Triangle();
        }


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                triangle.Points = objTriangle.CalculateCoordinatesPoints(
                    Convert.ToDouble(sizeAB.Text),
                    Convert.ToDouble(sizeBC.Text),
                    Convert.ToDouble(sizeCA.Text));
                S.Text = objTriangle.S.ToString() + "мм^2";
                P.Text = objTriangle.P.ToString() + "мм";
            }
            catch (ArgumentException)
            {
                ContentDialog contentDialog = new ContentDialog()
                {
                    Title = "Ошибка",
                    Content = "Один или несколько параметров были заданы неверно",
                    PrimaryButtonText = "ОК"
                };
                ContentDialogResult result = await contentDialog.ShowAsync();
            }
            catch (FormatException)
            {
                ContentDialog contentDialog = new ContentDialog()
                {
                    Title = "Ошибка",
                    Content = "Один или несколько параметров были заданы неверно",
                    PrimaryButtonText = "ОК"
                };
                ContentDialogResult result = await contentDialog.ShowAsync();
            }

        }
    }
}

