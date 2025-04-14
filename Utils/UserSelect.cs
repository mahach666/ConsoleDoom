using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace RevitDoomNetPort.Utils
{
    internal static class UserSelect
    {
        public static string GetWad()
        {
            Application.EnableVisualStyles();

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Выберите WAD-файл";
            dialog.Filter = "WAD файлы (*.wad)|*.wad|Все файлы (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            else
            {
               return null;
            }
        }
    }
}
