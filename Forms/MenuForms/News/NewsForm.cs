using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.News
{
    public partial class NewsForm : MaterialForm
    {
        private DesingerService desingerService;
        public NewsForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            desingerService.AddPanelToChangeColor(panel1);
            desingerService.AddPanelToChangeColor(panel2);
            desingerService.AddPanelToChangeColor(panel3);
            desingerService.AddPanelToChangeColor(panel4);
            desingerService.AddPanelToChangeColor(panel5);
            desingerService.AddPanelToChangeColor(panel6);
        }
    }
}
