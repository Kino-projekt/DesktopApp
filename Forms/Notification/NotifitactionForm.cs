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

namespace DesktopApp.Forms.Notification
{
    public partial class NotifitactionForm : MaterialForm
    {
        private DesingerService desingerService;
        public NotifitactionForm(string message)
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(contentPanel);
            textLabel.Text = message;
        }

        private void NotifitactionForm_Load(object sender, EventArgs e)
        {
            Top = 20;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        public static void ShowMessage(string text)
        {
            NotifitactionForm dialog = new NotifitactionForm(text);
            dialog.Show();
        }
    }
}
