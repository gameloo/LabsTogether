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
    public sealed partial class Lab7Task2 : Page
    {
        public Lab7Task2()
        {
            this.InitializeComponent();
        }

        private async void Remove_Substring_Click_Async(object sender, RoutedEventArgs e)
        {
            try
            {
                tbString.Text = new Regex(tbSubstring.Text).Replace(tbString.Text, "");
            }
            catch (Exception ex)
            {
                await other.Window.ShowErrorWindowAsync(ex);
            }
        }
    }

    
}
