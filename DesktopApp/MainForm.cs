using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;

        public MainForm()
        {
            InitializeComponent();
            
            
        }

        private void btnPremiere_Click(object sender, EventArgs e)
        {

            openContentForm(new PremiereForm());

        }

        private void openContentForm(Form newForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(newForm);
            contentPanel.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }
    }
}
