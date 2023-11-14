using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank_2
{
    internal class bank
    {
        private int account_number;
        private string name;
        private float sum_account;
        private float dob;
        private float umen;
        private void otk()
        {
            Console.Write("Введите номер своего счета: ");
            account_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свое ФИО: ");
            name = Console.ReadLine();
            Console.Write("Введите сумму, которую хотели бы положить на счет: ");
            sum_account = float.Parse(Console.ReadLine());
        }
        private void Out()
        {
            Console.WriteLine("Информация о вашем счете: ");
            Console.WriteLine($"Номер счета: {account_number}");
            Console.WriteLine($"ФИО: {name}");
            Console.WriteLine($"Сумма на счету: {sum_account}");
        }
        private void Dob()
        {
            Console.Write("Введите сумму, которую хотели бы добавить на ваш счет: ");
            dob = float.Parse(Console.ReadLine());
            sum_account = sum_account + dob;
            Console.WriteLine($"Сумма на счету: {sum_account}");
        }
        private void Umen()
        {
            Console.Write("Введите сумму, которую хотите снять со счета: ");
            umen = float.Parse(Console.ReadLine());
            if (umen > sum_account)
            {
                Console.WriteLine("У вас недостаточно средств");
            }
            else
            {
                sum_account = sum_account - umen;
                Console.WriteLine($"Сумма на вашем счету: {sum_account}");
            }
        }
        private void Obnul()
        {
            Console.WriteLine($"Снятие всей суммы: {sum_account}");
            sum_account = sum_account - sum_account;
        }
        private void Perenos(int account, List<bank> account_numbers, int number)
        {
            if (account == number)
            {
                Console.WriteLine("Вы не можете переводить деньги со своего счета на свой");
            }
            else
            {
                Console.Write("Введите сумму, которую хотели бы добавить на счет: ");
                dob = float.Parse(Console.ReadLine());
                foreach (bank perevod in account_numbers)
                {
                    if (dob < sum_account)
                    {
                        perevod.sum_account = perevod.sum_account + dob;
                        sum_account = sum_account - dob;
                    }
                }
                Console.WriteLine($"Сумма на счету {name}: {sum_account}");
            }
        }
        public void Vibor(int vib, int account, List<bank> account_numbers, int number)
        {
            switch (vib)
            {
                case 0: { otk(); break; }
                case 1: { Out(); break; }
                case 2: { Dob(); break; }
                case 3: { Umen(); break; }
                case 4: { Obnul(); break; }
                case 5: { Perenos(account, account_numbers, number); ; break; }
            }
        }
    }
}