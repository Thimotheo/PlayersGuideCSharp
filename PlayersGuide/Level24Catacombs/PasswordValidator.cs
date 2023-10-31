using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level24Catacombs
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (password.Length < 6)
                return false;
            if (password.Length > 13)
                return false;
            if (!HasUppercase(password))
                return false;
            if (!HasLowercase(password))
                return false;
            if (!HasDigit(password))
                return false;
            if (ContainsTOrAmpersand(password))
                return false;

            return true;
        }

        private bool HasUppercase(string password)
        {
            foreach (char letter in password)
            {
                if (char.IsUpper(letter))
                {
                    return true;
                }
            }
            return false;
        }

        private bool HasLowercase(string password)
        {
            foreach (char letter in password)
            {
                if (char.IsLower(letter))
                {
                    return true;
                }
            }
            return false;
        }

        private bool HasDigit(string password)
        {
            foreach (char letter in password)
            {
                if (char.IsDigit(letter))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsTOrAmpersand(string password)
        {
            if (password.Contains('T'))
                return true;
            if (password.Contains('&'))
                return true;

            return false;
        }
    }
}
