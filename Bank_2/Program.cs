using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vib;
            int number = 0;
            List<bank> account_numbers = new List<bank>();
            bank pol = new bank();
            bank pol2 = new bank();
            account_numbers.Add(pol);
            account_numbers.Add(pol2);
            Console.WriteLine("Перед началом работы необходимо выьрать счет (сейчас он пустой)");
            Console.WriteLine("Нажмитие ниже: 1 или 2");
            int account = Convert.ToInt32(Console.ReadLine()) - 1;
            do
            {
                Console.WriteLine("Что вы хотели бы сделать?");
                Console.WriteLine("0. Создать счет\n1. Показать инф о счете;\n2. Положить на счет;\n3. Снять со счета;\n4. Взять всю сумму;\n5. Перенести сумму с одного счета на другой.;\n6. Сменить счет. ");
                vib = Convert.ToInt32(Console.ReadLine());
                switch (vib)
                {
                    case 0: { account_numbers[account].Vibor(vib, account, account_numbers, number); break; }
                    case 1: { account_numbers[account].Vibor(vib, account, account_numbers, number); break; }
                    case 2: { account_numbers[account].Vibor(vib, account, account_numbers, number); break; }
                    case 3: { account_numbers[account].Vibor(vib, account, account_numbers, number); break; }
                    case 4: { account_numbers[account].Vibor(vib, account, account_numbers, number); break; }
                    case 5:
                        {
                            Console.WriteLine("Введите номер счета, на который хотите перенести деньги(1 или 2)");
                            number = Convert.ToInt32(Console.ReadLine()) - 1;
                            account_numbers[account].Vibor(vib, account, account_numbers, number);
                            break;
                        }
                    case 6:
                        {
                            if (account == 0)
                            {
                                account = 1;
                            }
                            else account = 0;
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
            } while (vib < 7);
        }
    }
}
