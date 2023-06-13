using System.Text.RegularExpressions;

namespace ValidationExtensions
{
    public static class StringExtensions
    {
        public static bool IsValidEmail(this string email)
        {
            string pattern = @"^\w+(?:\w+|\.)\w+\@\w+\.\w{2,4}$";
            if (email == null)
            {
                throw new ArgumentNullException();
            }
            if (Regex.IsMatch(email!, pattern))
            {
                return true;
            }
            return false;
        }

        public static bool IsValidNLPhoneNr(this string phone)
        {
            string pattern = @"(?:00|\+)31(\d){9}$";

            if (Regex.IsMatch(phone, pattern))
            {
                return true;
            }
            return false;
        }

        public static bool IsValidPassword(this string password)
        {
            string pattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%\^&(){}[\]:;<>,.?/~_+\-=|\\]).{8,}$";
            if (password == null) { throw new ArgumentNullException(); }
            if (Regex.IsMatch(password!, pattern))
            {
                return true;
            }
            return false;
        }

        public static string ReplaceEmails(this string text)
        {
            //string pattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%\^&(){}[\]:;<>,.?/~_+\-=|\\]).{8,}$";

            Regex emailReplace = new Regex(@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}", RegexOptions.IgnoreCase);
            string replacedText = emailReplace.Replace(text, "********");
            return replacedText;
        }
    }
}