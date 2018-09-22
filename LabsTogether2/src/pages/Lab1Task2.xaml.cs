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
    public sealed partial class Lab1Task2 : Page
    {
        public Lab1Task2()
        {
            this.InitializeComponent();
        }

        private void Triangle_Click(object sender, RoutedEventArgs e)
        {
            //RadioButton pressed = (RadioButton)sender;
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
    }
}
