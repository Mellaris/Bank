using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bank_final
{
    internal class bank
    {
        private int account_number;
        private string name;
        private float sum_account;
        private float dob;
        private float umen;
        public void Ot(List<bank> account_numbers)
        {
            account_numbers.Add(new bank());
            bank pol = account_numbers.Last();
            pol.otk();
            Console.ReadKey();
            Console.Clear();
            this.Perexod(account_numbers);
        }
        private void otk()
        {       
            Console.Write("Укажите номер своего индивидуального счета: ");
            account_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свое ФИО: ");
            name = Console.ReadLine();
            Console.Write("Введите сумму, которую хотели бы положить на счет: ");
            sum_account = float.Parse(Console.ReadLine());
        }
        private void Out()
        {
            Console.WriteLine("Информация о вашем счете: ");
            Console.WriteLine($"Номер счета: {this.account_number}");
            Console.WriteLine($"ФИО: {this.name}");
            Console.WriteLine($"Сумма на счету: {this.sum_account}");
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
        private void Perexod(List<bank> account_numbers)
        {
            Console.WriteLine("Укажите номер счета, на который хотите перейти: ");
            foreach (bank perexod in account_numbers)
            {
                perexod.Out();
                Console.WriteLine();
            }
            int number = Convert.ToInt32(Console.ReadLine());
            foreach (bank perexod in account_numbers)
            {
                if (number == perexod.account_number)
                {
                    perexod.Vibor(account_numbers);
                    break;
                }
            }
        }
        private void Perenos(List<bank> account_numbers)
        {
            Console.WriteLine("Введите номер счета, на который хотите перенести деньги: ");
            foreach (bank perexod in account_numbers)
            {
                perexod.Out();
                Console.WriteLine();
            }
            int number = Convert.ToInt32(Console.ReadLine());
            foreach (bank perevod in account_numbers)
            {
                if (number == this.account_number)
                {
                    Console.WriteLine("Вы не можете переводить деньги со своего счета на свой");
                }
                else if (number == perevod.account_number)
                {
                    Console.Write("Введите сумму, которую хотели бы добавить на счет: ");
                    dob = float.Parse(Console.ReadLine());
                    if (dob > this.sum_account)
                    {
                        Console.WriteLine("У вас недостаточно денег");
                    }
                    else
                    {
                        perevod.sum_account = perevod.sum_account + dob;
                        this.sum_account = this.sum_account - dob;
                    }
                }
            }
        }
        private void Vibor(List<bank> account_numbers)
        {
            Console.WriteLine("Что вы хотели бы сделать?");
            Console.WriteLine("0. Создать счет\n1. Показать инф о счете;\n2. Положить на счет;\n3. Снять со счета;\n4. Взять всю сумму;\n5. Перенести сумму с одного счета на другой.;\n6. Сменить счет. ");
            int vib = Convert.ToInt32(Console.ReadLine());
            switch (vib)
            {
                case 0:
                    {
                        Ot(account_numbers);
                        break;
                    }
                case 1:
                    {
                        Out();
                        Console.ReadKey();
                        Console.Clear();
                        Vibor(account_numbers);
                        break;
                    }
                case 2:
                    {
                        Dob();
                        Console.ReadKey();
                        Console.Clear();
                        Vibor(account_numbers);
                        break;
                    }
                case 3:
                    {
                        Umen();
                        Console.ReadKey();
                        Console.Clear();
                        Vibor(account_numbers);
                        break;
                    }
                case 4:
                    {
                        Obnul();
                        Console.ReadKey();
                        Console.Clear();
                        Vibor(account_numbers);
                        break;
                    }
                case 5:
                    {
                        Perenos(account_numbers);
                        Console.ReadKey();
                        Console.Clear();
                        Vibor(account_numbers);
                        break;
                    }
                case 6:
                    {
                        Perexod(account_numbers);
                        break;
                    }
            }
        }
    }
}
