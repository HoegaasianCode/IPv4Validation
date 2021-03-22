using System;

namespace IPv4Validation
{
    class Program
    {
        // https://edabit.com/challenge/BNKRr4N2oFZQfrTY3
        // SOLVED

        static void Main(string[] args)
        {
            IPv4Validation ip = new ("201.137.43.53");
            ip.SplitToFields();
            ip.IsIPv6();
            ip.IsLeadingZeroInField();
            ip.IsCorrectFieldRange();
            ip.IsLastIPDigitZero();
            Console.Write(ip.IsIPv4Valid());
        }
    }
}
