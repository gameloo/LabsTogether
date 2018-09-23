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
    public sealed partial class Lab4 : Page
    {
        public Lab4()
        {
            this.InitializeComponent();
            tbA = new TextBox();
            tbA.PlaceholderText = "a";
            tbA.Margin = new Thickness(5);
            tbB = new TextBox();
            tbB.PlaceholderText = "b";
            tbB.Margin = new Thickness(5);
            tbR = new TextBox();
            tbR.PlaceholderText = "R";
            tbR.Margin = new Thickness(5);
            tbH = new TextBox();
            tbH.PlaceholderText = "h";
            tbH.Margin = new Thickness(5);
        }

        private TextBox tbA;
        private TextBox tbB;
        private TextBox tbR;
        private TextBox tbH;

        /// <summary>
        /// (string a, string b, string R, string h,)
        /// </summary>
        private Func<string, string, string, string, double> operation;

        private void TbN_TextChanged(object sender, TextChangedEventArgs e)
        {
            spParams.Children.Clear();
            btnCalculate.IsEnabled = true;

            switch (tbN.Text)
            {
                case "1":
                    {
                        spParams.Children.Add(tbA);
                        spParams.Children.Add(tbB);
                        operation = (string tbA, string tbB, string tbR, string tbH) => { return Double.Parse(tbA) * Double.Parse(tbB); };
                        break;
                    }
                case "2":
                    {
                        spParams.Children.Add(tbA);
                        spParams.Children.Add(tbH);
                        operation = (string tbA, string tbB, string tbR, string tbH) => { return Double.Parse(tbA) * Double.Parse(tbH) / 2; };
                        break;
                    }
                case "3":
                    {
                        spParams.Children.Add(tbA);
                        spParams.Children.Add(tbB);
                        spParams.Children.Add(tbH);
                        operation = (string tbA, string tbB, string tbR, string tbH) => { return (Double.Parse(tbA) + Double.Parse(tbB)) * Double.Parse(tbH) / 2; };
                        break;
                    }
                case "4":
                    {
                        spParams.Children.Add(tbR);
                        operation = (string tbA, string tbB, string tbR, string tbH) => { return Math.PI * Math.Pow(Double.Parse(tbR), 2); };
                        break;
                    }
                case "5":
                    {
                        spParams.Children.Add(tbR);
                        spParams.Children.Add(tbA);
                        operation = (string tbA, string tbB, string tbR, string tbH) => { return Math.PI * Math.Pow(Double.Parse(tbR), 2) * Double.Parse(tbA) / 360; };
                        break;
                    }
                default:
                    {
                        btnCalculate.IsEnabled = false;
                        break;
                    }
            }
        }

        private async void BtnCalculate_ClickAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                tbS.Text = operation(tbA.Text, tbB.Text, tbR.Text, tbH.Text).ToString();
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }
    }
}
