using System.Windows.Forms;
using DesktopApp.Backend.Controllers.ContentPanel.Methods;
using DesktopApp.Forms.MenuForms.News;
using DesktopApp.Forms.MenuForms.Price;
using DesktopApp.Forms.MenuForms.Seance;
using DesktopApp.Forms.MenuForms.Settings;

namespace DesktopApp.Backend.Controllers.ContentPanel
{
    public class ContentPanelControllerImpl : ContentPanelController
    {
        private ContentCreator content;

        public static ContentPanelController CreateController(Panel panel)
        {
            return new ContentPanelControllerImpl(panel);
        }

        private ContentPanelControllerImpl(Panel panel)
        {
            content = new ContentCreator(panel);
        }

        public void OpenSettingForm()
        {
            content.Open(new SettingsForm());
        }

        public void OpenPriceForm()
        {
            content.Open(new PriceForm());
        }

        public void OpenNewsForm()
        {
            content.Open(new NewsForm());
        }

        public void OpenSeanceForm()
        {
            content.Open(new SeanceForm());
        }
    }
}