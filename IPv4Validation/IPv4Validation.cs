using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IPv4Validation
{
    public class IPv4Validation
    {
        private readonly string _ip;
        private string[] IpArray { get; set; }
        private bool IsValid { get; set; }

        public IPv4Validation(string ip)
        {
            _ip = ip;
            IsValid = true;
        }
        
        public void IsIPv6()
        {
            if (_ip[5] == ':') IsValid = false;
        }
        
        public void SplitToFields()
        {
            IpArray = _ip.Split('.');
        }

        public void IsLeadingZeroInField()
        {
            for(int i = 0; i < IpArray.Length; i++)
            {
                string field = IpArray[i];
                if (field[0] == '0')
                {
                    IsValid = false;
                    break;
                }
            }
        }

        public void IsCorrectFieldRange()
        {
            short x;
            for(int i = 0; i < IpArray.Length; i++)
            {
                string field = IpArray[i];
                x = Int16.Parse(field);
                if (x > 255 || x < 1)
                {
                    IsValid = false;
                    break;
                }
            }
        }

        public void IsLastIPDigitZero()
        {
            Array.Reverse(IpArray);
            for(int i = IpArray.Length - 1; i >= 0; i--)
            {
                string lastField = IpArray[i];
                if (lastField.Last() == '0') IsValid = false;
            }
        }

        public bool IsIPv4Valid() => IsValid;

    }
}
