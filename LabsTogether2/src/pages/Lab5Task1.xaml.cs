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
    public sealed partial class Lab5Task1 : Page
    {
        List<TextBox> listElements;
        TextBox minElement;

        public Lab5Task1()
        {
            this.InitializeComponent();
            listElements = new List<TextBox>() { tbX1, tbX2, tbX3 };
        }

        private void TbX1_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoSmthAsync(tbX1);
        }

        private void TbX2_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoSmthAsync(tbX2);
        }

        private void TbX3_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoSmthAsync(tbX3);
        }

        private async void DoSmthAsync(TextBox sender)
        {
            try
            {
                if (sender.Equals(minElement))
                {
                    bool listHaveNum = false;
                    foreach (TextBox box in listElements)
                        if (box.Text != "")
                        {
                            listHaveNum = true;
                            minElement = box;
                            break;
                        }
                    if (!listHaveNum)
                    {
                        minElement = null;
                        tblMinElement.Text = "-";
                        return;
                    }
                }

                if (minElement == null)
                {
                    if (sender.Text != "")
                        minElement = sender;
                    else return;
                }
                else
                {
                    foreach (TextBox box in listElements)
                        if (box.Text != "")
                        {
                            if (Double.Parse(minElement.Text) > Double.Parse(box.Text)) minElement = box;
                        }
                }

                switch (minElement.Name)
                {
                    case "tbX1":
                        {
                            tblMinElement.Text = "x1";
                            break;
                        }
                    case "tbX2":
                        {
                            tblMinElement.Text = "x2";
                            break;
                        }
                    case "tbX3":
                        {
                            tblMinElement.Text = "x3";
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                await other.Window.ShowErrorWindowAsync(e);
            }


        }
    }
}
