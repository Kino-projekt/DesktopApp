using System.Windows.Forms;

namespace DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo
{
    public class DialogMessage
    {
        public static void ShowInfo(string message)
        {
            DialogResult dialog = dialog = MessageBox.Show(message, "Scruter", MessageBoxButtons.OK);
        }
    }
}