using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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
    public sealed partial class Lab7Task1 : Page
    {
        public Lab7Task1()
        {
            this.InitializeComponent();
        }

        private async void Calculate_Click_Async(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(tbCharA.Text, @"^[a-z|A-Z|а-я|А-Я]{1}$")) throw new ArgumentException();
                if (!Regex.IsMatch(tbCharB.Text, @"^[a-z|A-Z|а-я|А-Я]{1}$")) throw new ArgumentException();

                int aCount = new Regex(tbCharA.Text).Matches(tbString.Text).Count;
                int bCount = new Regex(tbCharB.Text).Matches(tbString.Text).Count;
                tblCountA.Text = aCount.ToString();
                tblCountB.Text = bCount.ToString();

                StringBuilder stringInfo = new StringBuilder("Сумма a и b: ");

                stringInfo.Append((aCount + bCount) + ", ");
                if (aCount > bCount) stringInfo.Append("a > b");
                else if (aCount < bCount) stringInfo.Append("a < b");
                else stringInfo.Append("a == b");

                tblMoreCountInfo.Text = stringInfo.ToString();
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }
    }
}
