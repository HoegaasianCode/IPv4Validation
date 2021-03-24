using System;

namespace IPv4Validation
{
    public class IPv4Validation
    {
        private readonly string _ip;
        private string[] IPv4Array { get; set; }
        private string[] IPv4ArrayReversed { get; set; }
        private bool IsValid { get; set; }

        public IPv4Validation(string ip)
        {
            _ip = ip;
            IsValid = true;
        }


        public void IsIPv6()
        {
            if (_ip[4] == ':' && _ip.Length > 15) IsValid = false;
        }

        public void IsLeadingZeroInField()
        {
            for(int i = 0; i < IPv4Array.Length; i++)
            {
                string field = IPv4Array[i];
                string reversedField = IPv4ArrayReversed[i];
                if (field.Length <= 1) continue;
                if (field.Length == 2 && field[0] == '0') IsValid = false;
                if (field.Length > 2 && reversedField[0] != '0' && field[1] == '0'
                    && field[0] != '0') IsValid = false;
            }
        }

        public void IsCorrectFieldRange()
        {
            for(int i = 0; i < IPv4Array.Length; i++)
            {
                string field = IPv4Array[i];
                short t = Int16.Parse(field);
                if (t > 255 || t < 0)
                {
                    IsValid = false;
                    break;
                }
            }
        }

        public void IsLastFieldZero()
        {
            if (IPv4ArrayReversed[0] == "0") IsValid = false;
        }

        public bool IsIPv4Valid() => IsValid;

        public void SplitToOctats()
        {
            IPv4Array = _ip.Split('.');
        }

        public void CreateReversedIPArray()
        {
            IPv4ArrayReversed = IPv4Array;
            Array.Reverse(IPv4ArrayReversed);
        }
    }
}
