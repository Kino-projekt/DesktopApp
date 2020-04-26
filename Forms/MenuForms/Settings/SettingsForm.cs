using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Settings
{
    public partial class SettingsForm : MaterialForm
    {
        private DesingerService desingerService;

        public SettingsForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(themePanel);
        }


        private void blueButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.Blue);
            desingerService.SetDarkTheme();

        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.Green);
            desingerService.SetDarkTheme();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.Red);
            desingerService.SetDarkTheme();
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.Purple);
            desingerService.SetDarkTheme();
        }
    }
}
