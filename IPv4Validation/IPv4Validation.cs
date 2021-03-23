using System;

namespace IPv4Validation
{
    public class IPv4Validation
    {
        private readonly string _ip;
        private string[] IPv4Array { get; set; }
        private bool IsValid { get; set; }

        public IPv4Validation(string ip)
        {
            _ip = ip;
            IsValid = true;
        }

        public void IsIPv6()
        {
            if (_ip[4] == ':') IsValid = false;
            else IPv4Array = _ip.Split('.');
        }

        public void IsLeadingZeroInField()              // "0.0023.043.90"
        {                                               // if a non-last index of a field is 0 :
            for(int i = 0; i < IPv4Array.Length; i++)   // (1) the field contains a string of only 0's, (2) a lone "0", or (3), a leading 0.
            {                                           // (1) is per definition not a leading 0, (2) can be checked by adding logical requirements,
                string field = IPv4Array[i];            // leaving only (3)
            }
        }

        public void IsCorrectFieldRange()
        {
            for(int i = 0; i < IPv4Array.Length; i++)
            {
                string field = IPv4Array[i];
                short t = Int16.Parse(field);
                if (t > 255 || t <= 0)
                {
                    IsValid = false;
                    break;
                }
            }
        }

        public void IsLastDigitInLastFieldZero() // "0.0123.043.90"
        {
            for(int i = IPv4Array.Length - 1; i >= 0; i--)
            {
                string lastField = IPv4Array[i];
                for(int j = lastField.Length - 1; j >= 0; j--)
                {
                    char c = lastField[j];
                    if (c == '0' && lastField.Length >= 1)
                    {
                        IsValid = false;
                        i = -1;
                        break;
                    }
                }
            }
        }

        public bool IsIPv4Valid() => IsValid;

    }
}
