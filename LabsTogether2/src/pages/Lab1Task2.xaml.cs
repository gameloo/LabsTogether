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
    public sealed partial class Lab1Task2 : Page
    {
        public Lab1Task2()
        {
            this.InitializeComponent();
        }

        private void Triangle_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(rbArbitraryTriangle))
            {
                spArbitraryTriangle.Visibility = Visibility.Visible;
                spEquilateralTriangle.Visibility = Visibility.Collapsed;
                spRightTriangle.Visibility = Visibility.Collapsed;
            }
            else if (sender.Equals(rbEquilateralTriangle))
            {
                spArbitraryTriangle.Visibility = Visibility.Collapsed;
                spEquilateralTriangle.Visibility = Visibility.Visible;
                spRightTriangle.Visibility = Visibility.Collapsed;
            }
            else if (sender.Equals(rbRightTriangle))
            {
                spArbitraryTriangle.Visibility = Visibility.Collapsed;
                spEquilateralTriangle.Visibility = Visibility.Collapsed;
                spRightTriangle.Visibility = Visibility.Visible;
            }

        }

        private void PrepareStackPanelCalculate()
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tbResult.Text = "";
            tb1.Visibility = Visibility.Visible;
            tb2.Visibility = Visibility.Visible;
            tb3.Visibility = Visibility.Visible;
            spCalculate.Visibility = Visibility.Visible;
        }

        private Func<string, string, string, double> operation;

        private void Rba_Click(object sender, RoutedEventArgs e)
        {
            PrepareStackPanelCalculate();

            if (sender.Equals(rba1))
            {
                tb1.PlaceholderText = "Сторона треугольника";
                tb2.PlaceholderText = "Высота проведенная к стороне";
                tb3.Visibility = Visibility.Collapsed;
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().ArbitraryTriangleСalculateS(Double.Parse(tb1), Double.Parse(tb2));
                };
            }
            else if (sender.Equals(rba2))
            {
                tb1.PlaceholderText = "Сторона треугольника";
                tb2.PlaceholderText = "Сторона треугольника";
                tb3.PlaceholderText = "Угол между сторонами";
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().ArbitraryTriangleСalculateS(Double.Parse(tb1), Double.Parse(tb2), Double.Parse(tb3), false);
                };
            }
            else if (sender.Equals(rba3))
            {
                tb1.PlaceholderText = "Сторона треугольника";
                tb2.PlaceholderText = "Сторона треугольника";
                tb3.PlaceholderText = "Сторона треугольника";
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().ArbitraryTriangleСalculateS(Double.Parse(tb1), Double.Parse(tb2), Double.Parse(tb3));
                };
            }
            else if (sender.Equals(rba4))
            {
                tb1.PlaceholderText = "Полупериметр";
                tb2.PlaceholderText = "Радиус вписанной окружности";
                tb3.Visibility = Visibility.Collapsed;
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().ArbitraryTriangleСalculateS1(Double.Parse(tb1), Double.Parse(tb2));
                };
            }
            else if (sender.Equals(rba5))
            {
                tb1.PlaceholderText = "Произведение сторон";
                tb2.PlaceholderText = "Радиус описанной окружности";
                tb3.Visibility = Visibility.Collapsed;
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().ArbitraryTriangleСalculateS2(Double.Parse(tb1), Double.Parse(tb2));
                };
            }
        }

        private void Rbe_Click(object sender, RoutedEventArgs e)
        {
            PrepareStackPanelCalculate();

            if (sender.Equals(rbe1))
            {
                tb1.PlaceholderText = "Сторона треугольника";
                tb2.Visibility = Visibility.Collapsed;
                tb3.Visibility = Visibility.Collapsed;
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().EquilateralTriangleСalculateS(Double.Parse(tb1));
                };
            }
            else if (sender.Equals(rbe2))
            {
                tb1.PlaceholderText = "Радиус вписанной окружности";
                tb2.Visibility = Visibility.Collapsed;
                tb3.Visibility = Visibility.Collapsed;
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().EquilateralTriangleСalculateS1(Double.Parse(tb1));
                };
            }
            else if (sender.Equals(rbe3))
            {
                tb1.PlaceholderText = "Радиус описанной окружности";
                tb2.Visibility = Visibility.Collapsed;
                tb3.Visibility = Visibility.Collapsed;
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().EquilateralTriangleСalculateS2(Double.Parse(tb1));
                };
            }
        }

        private void Rbr_Click(object sender, RoutedEventArgs e)
        {
            PrepareStackPanelCalculate();

            if (sender.Equals(rbr1))
            {
                tb1.PlaceholderText = "Катет";
                tb2.PlaceholderText = "Катет";
                tb3.Visibility = Visibility.Collapsed;
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().RightTriangleСalculateS(Double.Parse(tb1), Double.Parse(tb2));
                };
            }
            else if (sender.Equals(rbr2))
            {
                tb1.PlaceholderText = "Катет";
                tb2.PlaceholderText = "Острый угол";
                tb3.Visibility = Visibility.Collapsed;
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().RightTriangleСalculateS(Double.Parse(tb1), Double.Parse(tb2), false);
                };
            }
            else if (sender.Equals(rbr3))
            {
                tb1.PlaceholderText = "Гипотенуза";
                tb2.PlaceholderText = "Острый угол";
                tb3.Visibility = Visibility.Collapsed;
                operation = (string tb1, string tb2, string tb3) =>
                {
                    return new Triangle().RightTriangleСalculateS(Double.Parse(tb1), Double.Parse(tb2), false);
                };
            }
        }

        private async void BtnCalculate_ClickAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                tbResult.Text = operation(tb1.Text, tb2.Text, tb3.Text).ToString();
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }
    }
}
