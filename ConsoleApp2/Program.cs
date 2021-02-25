using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДЗ_02 Структуры ветвления

            // 1. Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
            Console.WriteLine("Введите число A");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int numberB = Convert.ToInt32(Console.ReadLine());
            if (numberA>numberB)
            {
                Console.WriteLine("Ответ на первое задание: " + (numberA + numberB));
            }
            else if (numberA==numberB)
            {
                Console.WriteLine("Ответ на первое задание: " + (numberA * numberB));
            }
            else
            {
                Console.WriteLine("Ответ на первое задание: " + (numberA - numberB));
            }


            // 2. Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
            Console.WriteLine("Введите число X");
            int numberX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число Y");
            int numberY = Convert.ToInt32(Console.ReadLine());
            
            if (numberX > 0)
            {
                if (numberY > 0)
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится в первой четверти");
                }
                else if (numberY < 0)
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится в четвертой четверти");
                }
                else
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится на оси X");
                }
               
            }
            else if (numberX < 0)
            {
                if (numberY > 0)
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится во второй четверти");
                }
                else if (numberY < 0)
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится в третьей четверти");
                }
                else
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится на оси X");
                }
            }
            else
            {
                if (numberY == 0)
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") является началом координат");
                }
                else
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится на оси Y");
                }
            }

            // 3. Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.

            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int numberC = Convert.ToInt32(Console.ReadLine());

        }
    }
}
