﻿using System;
using System.Net.Security;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;
using DesktopApp.Properties;

namespace DesktopApp.Backend.Services.SaveServices
{
    public class SaveService
    {

        public static void SaveUser(AuthData user)
        {
            Settings.Default.Email = Cipher.Encrypt(user.GetEmail());
            Settings.Default.Password = Cipher.Encrypt(user.GetPassword());
            Settings.Default.Save();
        }

        public static void RemoveUser()
        {
            Settings.Default.Email = "";
            Settings.Default.Password = "";
            Settings.Default.Save();
        }

        public static AuthData GetUser()
        {
            string email = Cipher.Decrypty(Settings.Default.Email);
            string password = Cipher.Decrypty(Settings.Default.Password);
            return new AuthData(email, password);
        }
    }
}