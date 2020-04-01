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
        }

        private void darkColorButton_Click(object sender, EventArgs e)
        {
            desingerService.SetDarkTheme();
        }

        private void lightColorButton_Click(object sender, EventArgs e)
        {
            desingerService.SetLightTheme();
        }
    }
}
