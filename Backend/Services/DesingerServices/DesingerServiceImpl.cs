using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.Backend.Services.DesingerServices
{
    public class DesingerServiceImpl : DesingerService
    {
        private MaterialSkin.MaterialSkinManager manager;

        public DesingerServiceImpl()
        {
            manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.Theme = MaterialSkinManager.Themes.DARK;
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
    }
}