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
using LabsTogether2.src.pages;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace LabsTogether2
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lab1Task1));
        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lab1Task2));
        }

        private void Button_Click_Load_Lab_2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lab2));
        }

        private void MenuFlyoutItem_Click_Lab3Task1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lab3Task1));
        }

        private void MenuFlyoutItem_Click_Lab3Task2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lab3Task2));
        }

        private void Button_Click_Load_Lab_4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lab4));
        }

        private void MenuFlyoutItem_Click_Lab5Task1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lab5Task1));
        }

        private void MenuFlyoutItem_Click_Lab5Task2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lab5Task2));
        }

        private void MenuFlyoutItem_Click_Lab5Task3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lab5Task3));
        }

        private void MenuFlyoutItem_Click_Lab5Task4(object sender, RoutedEventArgs e)
        {
           Frame.Navigate(typeof(Lab5Task4));
        }
        
    }
}
