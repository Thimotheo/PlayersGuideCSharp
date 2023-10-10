using System.Text.RegularExpressions;

namespace MyValidationExtensions
{
    public static class StringExtensions
    {
        private const string EmailRegex = "\\w+(?:\\w+|\\.)\\w+\\@\\w+\\.\\w{2,4}";
        private const string StrictEmailRegex = $"^{EmailRegex}$";

        public static bool IsValidEmail(this string email)
        {
            if (email == null || email == string.Empty)
            {
                throw new ArgumentNullException("Value cannot be empty");
            }
            if (Regex.IsMatch(email!, StrictEmailRegex))
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
            if (password == null || password == string.Empty) { throw new ArgumentNullException("Value cannot be empty"); }
            if (Regex.IsMatch(password!, pattern))
            {
                return true;
            }
            return false;
        }

        public static string ReplaceEmails(this string text)
        {
            Regex emailReplace = new(EmailRegex, RegexOptions.IgnoreCase);

            string replacedText = emailReplace.Replace(text, "********");
            return replacedText;
        }
    }
}