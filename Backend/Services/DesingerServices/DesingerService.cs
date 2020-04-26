using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DesktopApp.Backend.Services.DesingerServices
{
    public interface DesingerService
    {
        void AddFormToDesinger(MaterialForm materialForm);

        void SetDarkTheme();

        void SetLightTheme();

        void AddPanelToChangeColor(Panel panel);

        void SetColorStyle(ColorStyle color);
    }
}