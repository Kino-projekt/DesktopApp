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
using DesktopApp.Backend.Services.SaveServices;
using DesktopApp.Forms.Notification;
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
            desingerService.AddPanelToChangeColor(deleteDataPanel);
            desingerService.AddPanelToChangeColor(authorPanel);
        }


        private void blueButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.Blue);
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.Green);
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.Red);
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.Purple);
        }

        private void newColorButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.LightBlue);
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.Orange);
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.Pink);
        }

        private void springButton_Click(object sender, EventArgs e)
        {
            desingerService.SetColorStyle(ColorStyle.LightGreen);
        }

        private void deleteDataButton_Click(object sender, EventArgs e)
        {
            SaveService.RemoveUser();
            NotifitactionForm.ShowMessage("Usunięto lokalne dane użytkownika!");
        }
    }
}
