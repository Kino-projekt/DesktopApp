using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesktopApp.Backend.Configuration
{
    public class DataValidation
    {
        private static int MIN_PASSWORD_SIZE = 6;
        private static int MAX_PASSWORD_SIZE = 20;

        public static bool CheckPassword(string password)
        {
            {
                if (String.IsNullOrEmpty(password) || password.Length < MIN_PASSWORD_SIZE  || password.Length > MAX_PASSWORD_SIZE)
                {
                    return false;
                }

                string pattern = "^[a-zA-Z0-9]+$";
                if (!Regex.IsMatch(password, pattern))

                {
                    return false;
                }
                return true;
            }
        }

        public static bool CheckEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


    }
}