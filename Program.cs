using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double k;
            Console.Write("Введите порядковый номер дня недели:  ");
            k = Convert.ToDouble(Console.ReadLine());
            {
                switch (k)
                {
                    case 1:
                        Console.Write("Понедельник");
                        break;
                    case 2:
                        Console.Write("Вторник");
                        break;
                    case 3:
                        Console.Write("Среда");
                        break;
                    case 4:
                        Console.Write("Четверг");
                        break;
                    case 5:
                        Console.Write("Пятница");
                        break;
                    case 6:
                        Console.Write("Суббота");
                        break;
                    case 7:
                        Console.Write("Воскресенье");
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                Console.ReadKey();

            }
        }
    }
}
