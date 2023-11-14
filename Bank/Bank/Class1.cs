using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank_Account
    {
        public static int account_number;
        public string name;
        public float sum_account;
        private float dob;
        private float umen;
        public static int n;
        public void otk()
        {
            //Console.Write("Введите номер своего счета: ");
            //account_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свое ФИО: ");
            name = Console.ReadLine();
            Console.Write("Введите сумму, которую хотели бы положить на счет: ");
            sum_account = float.Parse(Console.ReadLine());
            
        }
        public void Out()
        {
            Console.WriteLine("Информация о вашем счете: ");
            Console.WriteLine($"Номер счета: {account_number}");
            Console.WriteLine($"ФИО: {name}");
            Console.WriteLine($"Сумма на счету: {sum_account}");
            
        }
        public void Dob()
        {
            Console.Write("Введите сумму, которую хотели бы добавить на ваш счет: ");
            dob = float.Parse(Console.ReadLine());
            sum_account = sum_account + dob;
            Console.WriteLine($"Сумма на счету: {sum_account}");
        }
        public void Umen() 
        {
            Console.Write("Введите сумму, которую хотите снять со счета: ");
            umen = float.Parse(Console.ReadLine());
            if ( umen > sum_account )
            {
                Console.WriteLine("У вас недостаточно средств"); 
            }
            else
            {
                sum_account = sum_account - umen;
                Console.WriteLine($"Сумма на вашем счету: {sum_account}");
            }
        }
        public void Obnul()
        {
            Console.WriteLine($"Снятие всей суммы: {sum_account}");
            sum_account = sum_account - sum_account;
        }
        public void Perenos()
        {
            Console.Write("Введите сумму, которую хотели бы добавить на счет: ");
            dob = float.Parse(Console.ReadLine());
            sum_account = sum_account + dob;
            Console.WriteLine($"Сумма на счету {name}: {sum_account}");
        }
    }
}