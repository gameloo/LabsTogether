using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LabsTogether2.src.other
{
    public class Window
    {
        public static async Task ShowErrorWindowAsync(Exception e)
        {
            ContentDialog errorDialog = new ContentDialog()
            {
                Title = "Ошибка",
                Content = e.Message,
                PrimaryButtonText = "ОК",
            };

            ContentDialogResult result = await errorDialog.ShowAsync();
        }
    }
}
