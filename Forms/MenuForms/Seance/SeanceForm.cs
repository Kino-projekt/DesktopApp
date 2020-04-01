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

namespace DesktopApp.Forms.MenuForms.Seance
{
    public partial class SeanceForm : MaterialForm
    {
        private DesingerService desingerService;
        public SeanceForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
        }
    }
}
