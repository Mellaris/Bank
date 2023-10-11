using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_Account pol = new Bank_Account();
            pol.otk();
            Console.Clear();
            pol.Vibor();
            
        }
    }
}
