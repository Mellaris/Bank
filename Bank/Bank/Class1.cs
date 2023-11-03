using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank_Account
    {
        private int account_number;
        private string name;
        private float sum_account;
        private float dob;
        private float umen;
        private int account_number_2;
        private string name_2;
        private float sum_account_2;
        private int vibor;
        public void otk()
        {
            Console.Write("Введите номер своего счета: ");
            account_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свое ФИО: ");
            name = Console.ReadLine();
            Console.Write("Введите сумму, которую хотели бы положить на счет: ");
            sum_account = float.Parse(Console.ReadLine());
            Vibor_2();
        }
        private void Out()
        {
            Console.WriteLine("Информация о вашем счете: ");
            Console.WriteLine($"Номер счета: {account_number}");
            Console.WriteLine($"ФИО: {name}");
            Console.WriteLine($"Сумма на счету: {sum_account}");
            Vibor_2();
        }
        private void Dob()
        {
            Console.Write("Введите сумму, которую хотели бы добавить на ваш счет: ");
            dob = float.Parse(Console.ReadLine());
            sum_account = sum_account + dob;
            Console.WriteLine($"Сумма на счету: {sum_account}");
            Vibor_2();
        }
        private void Umen() 
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
            Vibor_2();
        }
        private void Obnul()
        {
            Console.WriteLine($"Снятие всей суммы: {sum_account}");
            sum_account = sum_account - sum_account;
            Vibor_2();
        }
        private void Perenos()
        {
            Console.Write("Введите сумму, которую хотели бы добавить на счет: ");
            dob = float.Parse(Console.ReadLine());
            sum_account = sum_account + dob;
            Console.WriteLine($"Сумма на счету {name}: {sum_account}");
            sum_account = sum_account - sum_account;
            Vibor_2();
        }
        public void Vibor()
        {
            Console.WriteLine("Что вы хотели бы сделать?");
            Console.WriteLine("0. Создать счет\n1. Показать инф о счете;\n2. Положить на счет;\n3. Снять со счета;\n4. Взять всю сумму;\n5. Перенести сумму с одного счета на другой. ");
            int vib = Convert.ToInt32(Console.ReadLine());
            if (vib == 0)
            {
                otk();
            }
            if (vib == 1)
            {
                Out();
            }
            if (vib == 2)
            {
                Dob();
            }
            if(vib == 3)
            {
                Umen();
            }
            if (vib == 4)
            {
                Obnul();
            }
            if (vib == 5)
            {
                Perenos();
            }
        }
        private void Vibor_2()
        {
            Console.WriteLine("Чтобы вернуться назад, нажмите 9");
            int vibor_2 = Convert.ToInt32(Console.ReadLine());
            if (vibor_2 == 9)
            {
                Console.Clear();
                Vibor();
            }
        }
    }
}