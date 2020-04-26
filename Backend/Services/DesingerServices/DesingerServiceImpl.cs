using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.Backend.Services.DesingerServices
{
    public class DesingerServiceImpl : DesingerService
    {
        private MaterialSkin.MaterialSkinManager manager;
        private static DesingerService desingerService = new DesingerServiceImpl();
        private List<Panel> panels;
        private ColorStyle color;

        public static DesingerService GetInstance()
        {
            return desingerService;
        }

        private DesingerServiceImpl()
        {
            manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.Theme = MaterialSkinManager.Themes.DARK;
            panels = new List<Panel>();
            color = ColorStyle.Blue;
        }

        public void AddFormToDesinger(MaterialForm materialForm)
        {
            manager.AddFormToManage(materialForm);
        }

        public void SetDarkTheme()
        {
            manager.Theme = MaterialSkinManager.Themes.DARK;
        }

        public void SetLightTheme()
        {
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public void AddPanelToChangeColor(Panel panel)
        {
            panels.Add(panel);
            SetColorForPanel(panel);
        }

        public void SetColorStyle(ColorStyle color)
        {
            this.color = color;
            foreach (var panel in panels)
            {
                SetColorForPanel(panel);
            }
        }

        private void SetColorForPanel(Panel panel)
        {
            if (color == ColorStyle.Blue)
            {
                panel.BackColor = Color.RoyalBlue;
                SetDarkTheme();
            }
            else if (color == ColorStyle.Red)
            {
                panel.BackColor = Color.DarkRed;
                SetDarkTheme();
            }
            else if (color == ColorStyle.Green)
            {
                panel.BackColor = Color.DarkGreen;
                SetDarkTheme();
            }
            else if (color == ColorStyle.Purple)
            {
                panel.BackColor = Color.DarkMagenta;
                SetDarkTheme();
            }
            else if (color == ColorStyle.Orange)
            {
                panel.BackColor = Color.Orange;
                SetLightTheme();
            }
            else if (color == ColorStyle.Pink)
            {
                panel.BackColor = Color.Tomato;
                SetLightTheme();
            }
            else if (color == ColorStyle.LightGreen)
            {
                panel.BackColor = Color.SpringGreen;
                SetLightTheme();
            }
            else if (color == ColorStyle.LightBlue)
            {
                panel.BackColor = Color.DeepSkyBlue;
                SetLightTheme();
            }
        }
    }
}