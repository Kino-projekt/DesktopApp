using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.AdminServices.HallsServices;
using DesktopApp.Backend.Services.AdminServices.UsersServices;
using DesktopApp.Backend.Services.BookingServices;
using DesktopApp.Backend.Services.DataServices.HallsServices;
using DesktopApp.Backend.Services.DataServices.MoviesServices;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Backend.Services.UserServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Seance
{
    public partial class SeanceInfoForm : MaterialForm
    {
        private DesingerService desingerService;
        private Backend.Data.Seance seance;

        public SeanceInfoForm(Backend.Data.Seance seance)
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(contentPanel);

            this.seance = seance;
            SetLabels();
        }

        private void SetLabels()
        {
            movieLabel.Text = "Film: " + seance.GetMovie().GetTitle();
            hallLabel.Text = "Sala: " + seance.GetHall().GetName();
            sizeLabel.Text = "Rozmiar sali: " + seance.GetHall().GetSeats();
            dateLabel.Text = seance.GetDate();

            if (MainUserServiceImpl.GetInstance().GetUserRole() == Role.DEFAULT)
                reservationPanel.Visible = false;
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            BookingService booking = BookingServiceImpl.GetService();
            ArrayList array = new ArrayList();
            array.Add((int)seatsNumerField.Value);
            booking.BookingSeats(seance, array);
        }
    }
}
