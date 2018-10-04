using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
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
    public sealed partial class Lab12 : Page
    {

        public Lab12()
        {
            this.InitializeComponent();
        }

        private async void BtnSave_Click_Async(object sender, RoutedEventArgs e)
        {
            var savePicker = new FileSavePicker();
            // место для сохранения по умолчанию
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            // устанавливаем типы файлов для сохранения
            savePicker.FileTypeChoices.Add("Текстовый документ в формате UTF-8", new List<string>() { ".txt" });
            // устанавливаем имя нового файла по умолчанию
            savePicker.SuggestedFileName = "New Document";
            savePicker.CommitButtonText = "Сохранить";

            var new_file = await savePicker.PickSaveFileAsync();
            if (new_file != null)
            {
                await FileIO.WriteTextAsync(new_file, tbWindow.Text);
            }
        }

        private async void BtnOpen_Click_Async(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.Desktop;
            openPicker.CommitButtonText = "Открыть";
            openPicker.FileTypeFilter.Add(".txt");
           
            var file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                try
                {
                    tbWindow.Text = await FileIO.ReadTextAsync(file, Windows.Storage.Streams.UnicodeEncoding.Utf8);
                }
                catch (Exception ex)
                {
                    await other.Window.ShowErrorWindowAsync(ex);
                }
            }
        }
    }
}
