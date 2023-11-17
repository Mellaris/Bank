using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <bank> account_numbers = new List<bank>();
            bank pol = new bank();
            pol.Ot(account_numbers);
        }
    }
}
