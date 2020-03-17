﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Services;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.RegistrationForm
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Close();
            FormService formService = FormsController.GetFormService();
            formService.OpenLoginForm();
        }

        private void regitstrationButton_Click(object sender, EventArgs e)
        {
            UserService userService = UserController.GetUserService();
            if (userService.RegisterNewUser(emailField.Text, passwordField.Text))
            {
                // Registraction currect
                Close();
            }
        }
    }
}
