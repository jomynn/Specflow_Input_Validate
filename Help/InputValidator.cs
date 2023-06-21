using System.Globalization;
using System.Net;

namespace Help
{
    public class InputValidator
    {
        public bool IsNumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool IsIPAddress(string input)
        {
            IPAddress ipAddress;
            return IPAddress.TryParse(input, out ipAddress);
        }

        public bool IsDate(string input, string format = "yyyy-MM-dd")
        {
            DateTime date;
            return DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
        }

        public bool IsText(string input)
        {
            return !string.IsNullOrEmpty(input) && !IsNumber(input) && !IsIPAddress(input) && !IsDate(input);
        }

        public bool IsEmail(string input)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(input);
                return address.Address == input;
            }
            catch
            {
                return false;
            }
        }

        public bool IsURL(string input)
        {
            Uri uriResult;
            return Uri.TryCreate(input, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
 

    }
}