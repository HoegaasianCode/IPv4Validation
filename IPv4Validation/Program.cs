using System;

namespace IPv4Validation
{
    class Program
    {
        // https://edabit.com/challenge/BNKRr4N2oFZQfrTY3
        // SOLVED

        static void Main(string[] args)
        {
            IPv4Validation ip = new ("0.155.43.0");
            ip.SplitToOctats();
            ip.CreateReversedIPArray();
            ip.IsIPv6();
            ip.IsLeadingZeroInField();
            ip.IsCorrectFieldRange();
            ip.IsLastFieldZero();
            Console.Write(ip.IsIPv4Valid());
        }
    }
}
