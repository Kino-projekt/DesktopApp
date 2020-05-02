using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.ContentPanel.Methods;
using DesktopApp.Backend.Services.DataServices.MoviesServices;
using MaterialSkin.Controls;

namespace DesktopApp.Backend.Controllers.Forms
{
    public class ListFormService
    {
        private List<Panel> panels;
        private List<MaterialForm> forms;
        private MaterialRaisedButton previusPageButton, nextPageButton;
        private MaterialLabel pageNumberLabel;
        private MaterialLabel infoLabel;
        private int pageNumber = 0;

        public ListFormService()
        {
        }

        public void ShowForms()
        {
            CleanContentPanel();
            if (forms != null&&panels!=null)
            {
                int i = 0;
                foreach (Panel panel in panels)
                {
                    int max = pageNumber * panels.Count + i;
                    if (max < forms.Count)
                    {
                        panel.Visible = true;
                        PanelCreator contentPanel = new PanelCreator(panel);
                        MaterialForm form = forms[max];
                        contentPanel.Open(form);
                        i++;
                    }
                }
            }
        }

        private void CleanContentPanel()
        {
            SetPageNumberLabel();
            SetButtonsVisible();

            foreach (Panel panel in panels)
            {
                panel.Visible = false;
            }
        }

        private void SetButtonsVisible()
        {
            previusPageButton.Visible = false;
            nextPageButton.Visible = false;
            if (pageNumber > 0)
                previusPageButton.Visible = true;
            int number = pageNumber + 1;
            if (number * panels.Count < forms.Count)
                nextPageButton.Visible = true;
        }

        public void NextPage()
        {
            pageNumber++;
            ShowForms();
        }

        public void PreviusePage()
        {
            pageNumber--;
            ShowForms();
        }

        private void SetPageNumberLabel()
        {
            if (forms.Count <= panels.Count)
            {
                pageNumberLabel.Visible = false;
            }
            else
            {
                pageNumberLabel.Visible = true;
                int number = pageNumber + 1;
                pageNumberLabel.Text = "Strona: " + number;
            }
        }

        public void SetPanels(List<Panel> panels)
        {
            this.panels = panels;
        }

        public void SetForms(List<MaterialForm> forms)
        {
            this.forms = forms;
            if (infoLabel != null)
            {
                if (forms == null || forms.Count >= 0)
                {
                    infoLabel.Visible = true;
                }
                else
                {
                    infoLabel.Visible = false;
                }
            }
        }

        public void SetControlButtonsAndLabel(MaterialRaisedButton previusButton, MaterialRaisedButton nextButton, MaterialLabel pageNumberLabel)
        {
            this.previusPageButton = previusButton;
            this.nextPageButton = nextButton;
            this.pageNumberLabel = pageNumberLabel;
        }

        public void SetInfoPanel(MaterialLabel info)
        {
            infoLabel = info;
        }

    }
}