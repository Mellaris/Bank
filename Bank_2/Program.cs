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
            int vib = 0;
            int number = 0;
            List<bank> account_numbers = new List<bank>();
            int account = 0;
            do
            {
                Console.WriteLine("Что вы хотели бы сделать?");
                Console.WriteLine("0. Создать счет\n1. Показать инф о счете;\n2. Положить на счет;\n3. Снять со счета;\n4. Взять всю сумму;\n5. Перенести сумму с одного счета на другой.;\n6. Сменить счет. ");
                vib = Convert.ToInt32(Console.ReadLine());
                switch (vib)
                {
                    case 0:
                        {
                            Console.Write("Укажите номер своего индивидуального счета: ");
                            account = Convert.ToInt32(Console.ReadLine()) - 1;
                            bank pol2 = new bank();
                            account_numbers.Insert(account, pol2);
                            account_numbers[account].Vibor(vib, account, account_numbers, number); break;
                        }
                    case 1: { account_numbers[account].Vibor(vib, account, account_numbers, number); break; }
                    case 2: { account_numbers[account].Vibor(vib, account, account_numbers, number); break; }
                    case 3: { account_numbers[account].Vibor(vib, account, account_numbers, number); break; }
                    case 4: { account_numbers[account].Vibor(vib, account, account_numbers, number); break; }
                    case 5:
                        {
                            Console.WriteLine("Введите номер счета, на который хотите перенести деньги");
                            Console.WriteLine($"Ваш текущий: {account + 1}");
                            number = Convert.ToInt32(Console.ReadLine()) - 1;
                            account_numbers[account].Vibor(vib, account, account_numbers, number);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Укажите счет, на который хотите перейти");
                            account = Convert.ToInt32(Console.ReadLine()) - 1;
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
            } while (vib < 7);
        }
    }
}
