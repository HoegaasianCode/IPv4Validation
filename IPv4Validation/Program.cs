using System;

namespace IPv4Validation
{
    class Program
    {
        // https://edabit.com/challenge/BNKRr4N2oFZQfrTY3
        // Needs a tad bit more work

        static void Main(string[] args)
        {
            IPv4Validation ip = new ("201.137.43.53");
            ip.IsIPv6();
            ip.SplitToFields();
            ip.IsLeadingZeroInField();
            ip.IsCorrectFieldRange();
            ip.IsLastIPDigitZero();
            Console.Write(ip.IsIPv4Valid());
        }
    }
}
