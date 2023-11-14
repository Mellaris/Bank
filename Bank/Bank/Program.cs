using System;
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
        public static int vib;
        public static void In()
        {
            Console.Write("Введите номер своего счета: ");
            Bank_Account.account_number = Convert.ToInt32(Console.ReadLine());
            if (vib == 5)
            {
                Console.WriteLine("Введите номер счета, на который хотите перенести деньги");
                Bank_Account.n = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            List<Bank_Account> account_numbers = new List<Bank_Account>();
            Bank_Account pol = new Bank_Account();
            Bank_Account pol2 = new Bank_Account();
            account_numbers.Add(pol);
            account_numbers.Add(pol2);
            do
            {
                Console.WriteLine("Что вы хотели бы сделать?");
                Console.WriteLine("0. Создать счет\n1. Показать инф о счете;\n2. Положить на счет;\n3. Снять со счета;\n4. Взять всю сумму;\n5. Перенести сумму с одного счета на другой. ");
                vib = Convert.ToInt32(Console.ReadLine());
                switch (vib)
                {
                    case 0:
                        {
                            Program.In();
                            account_numbers[Bank_Account.account_number].otk();
                        }
                        break;
                    case 1:
                        {
                            Program.In();
                            account_numbers[Bank_Account.account_number].Out();
                        }
                        break;
                    case 2:
                        {
                            Program.In();
                            account_numbers[Bank_Account.account_number].Dob();
                        }
                        break;
                    case 3:
                        {
                            Program.In();
                            account_numbers[Bank_Account.account_number].Umen();
                        }
                        break;
                    case 4:
                        {
                            Program.In();
                            account_numbers[Bank_Account.account_number].Obnul();
                        }
                        break;
                    case 5:
                        {
                            Program.In();
                            account_numbers[Bank_Account.account_number].Perenos();
                        }
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (vib < 6);
        }
    }
}
