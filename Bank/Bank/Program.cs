﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Bank_Account> account_number = new List <Bank_Account> ();
            Bank_Account pol = new Bank_Account();
            account_number.Add(pol);
            pol.otk();
            Console.Clear();
            pol.Vibor();           
        }
    }
}