using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.DataServices.MoviesServices;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Forms.MenuForms.News;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Movies
{
    public partial class MoviesForm : MaterialForm
    {
        private DesingerService desingerService;
        private MoviesService moviesService;
        private ListFormService listFormService;
        private List<Movie> movies;

        public MoviesForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);


            moviesService = MoviesServiceImpl.GetService();
            listFormService = new ListFormService();

            DownloadArticlesList();
            listFormService.SetControlButtonsAndLabel(previusPageButton, nextPageButton, pageNumberLabel);
            ConnectPanels();
            ConnectForms();

            listFormService.ShowForms();
        }

        private void ConnectForms()
        {
            List<MaterialForm> forms = new List<MaterialForm>();
            foreach (Movie movie in movies)
            {
                forms.Add(new MovieInfoForm(movie));
            }
            listFormService.SetForms(forms);
        }

        private void ConnectPanels()
        {
            List<Panel> panels = new List<Panel>();
            panels.Add(panel1);
            panels.Add(panel2);
            panels.Add(panel3);
            panels.Add(panel4);
            panels.Add(panel5);
            panels.Add(panel6);
            panels.Add(panel7);
            listFormService.SetPanels(panels);
        }


        private void DownloadArticlesList()
        {
            movies = moviesService.GetMoviesList();
            if (movies == null)
                infoLabel.Visible = true;
            else
                infoLabel.Visible = false;


        }

        private void previusPageButton_Click(object sender, EventArgs e)
        {
            listFormService.PreviusePage();
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            listFormService.NextPage();
        }
    }
}
