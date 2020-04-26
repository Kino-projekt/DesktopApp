using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DesktopApp.Properties;
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
            color = (ColorStyle) Settings.Default.Color;
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
            Properties.Settings.Default.Color = (int) color;
            Properties.Settings.Default.Save();
            foreach (var panel in panels)
            {
                SetColorForPanel(panel);
            }
        }

        private void SetColorForPanel(Panel panel)
        {
            switch (color)
            {
                case ColorStyle.Blue:
                    panel.BackColor = Color.RoyalBlue;
                    SetDarkTheme();
                    break;

                case ColorStyle.Red:
                    panel.BackColor = Color.DarkRed;
                    SetDarkTheme();
                    break;

                case ColorStyle.Green:
                    panel.BackColor = Color.DarkGreen;
                    SetDarkTheme();
                    break;

                case ColorStyle.Purple:
                    panel.BackColor = Color.DarkMagenta;
                    SetDarkTheme();
                    break;

                case ColorStyle.Orange:
                    panel.BackColor = Color.Orange;
                    SetLightTheme();
                    break;

                case ColorStyle.Pink:
                    panel.BackColor = Color.Tomato;
                    SetLightTheme();
                    break;

                case ColorStyle.LightGreen:
                    panel.BackColor = Color.SpringGreen;
                    SetLightTheme();
                    break;

                case ColorStyle.LightBlue:
                    panel.BackColor = Color.DeepSkyBlue;
                    SetLightTheme();
                    break;

            }
        }
    }
}