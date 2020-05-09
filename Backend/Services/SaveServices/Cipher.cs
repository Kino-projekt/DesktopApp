using System;

namespace DesktopApp.Backend.Services.SaveServices
{
    public class Cipher
    {
        public static string Encrypt(string text)
        {
            string output = "";
            char[] readChar = text.ToCharArray();
            for (int i = 0; i < readChar.Length; i++)
            {
                int no = Convert.ToInt32(readChar[i]) + 10;
                string r = Convert.ToChar(no).ToString();
                output += r;
            }

            return output;
        }

        public static string Decrypty(string text)
        {
            string output = "";
            char[] readChar = text.ToCharArray();
            for (int i = 0; i < readChar.Length; i++)
            {
                int no = Convert.ToInt32(readChar[i]) - 10;
                string r = Convert.ToChar(no).ToString();
                output += r;
            }
            return output;
        }
    }
}