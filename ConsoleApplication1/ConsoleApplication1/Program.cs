using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string alphanumeric = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            for(var i = 0; i<alphanumeric.Length; i++)
            {
                var character = Convert.ToChar(alphanumeric.Substring(i, 1));

                if (Check(Convert.ToInt32(character)))
                {
                    Console.WriteLine(character);
                }
}
        }

        private static bool Check(int value)
        {
            value *= 80;
            value -= 3915;
            value ^= 325;
            value *= value + 4091;
            value ^= 1411520;
            return (value == 0);
        }

    }
}
