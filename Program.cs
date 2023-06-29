using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Практика_с_циклами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string passvord = "7788";
            string userInput;

            for (int i = 0; i < tryCount; i++)
            {
                Console.WriteLine("Введите пароль:");
                userInput = Console.ReadLine();

                int remainingAttempts = tryCount - i - 1;

                if (passvord == userInput)
                {
                    Console.WriteLine("Пароль верный. Вы узнали все секреты мира!");
                    break;
                }

                else
                {
                    Console.WriteLine("Пароль не верный, у вас осталось " + (remainingAttempts) + " попыток.");
                }
            }
        }
    }
}
