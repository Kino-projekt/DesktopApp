using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DesktopApp.Backend.Controllers.ContentPanel.Methods
{
    public class ContentCreator
    {
        private Panel panel;
        private MaterialForm activeForm = null;

        public ContentCreator(Panel panel)
        {
            this.panel = panel;
        }

        public void Open(MaterialForm childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}