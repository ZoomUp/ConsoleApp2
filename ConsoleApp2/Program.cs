using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДЗ_02 Структуры ветвления

            // 1. Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
            Console.WriteLine("Задание №1");
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
            Console.WriteLine("Задание №2");
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
            Console.WriteLine("Задание №3");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int numberC = Convert.ToInt32(Console.ReadLine());

            if (numberA > numberB)
            {
                if (numberA > numberC)
                {
                    if (numberB > numberC)
                    {
                        Console.WriteLine("Ответ на третье задание: " + numberA + " " + numberB + " " + numberC);
                    }
                    else
                    {
                        Console.WriteLine("Ответ на третье задание: " + numberA + " " + numberC + " " + numberB);
                    }
                }
                else
                {
                    Console.WriteLine("Ответ на третье задание: " + numberC + " " + numberA + " " + numberB);
                }
            }
             else
            {
                if (numberB > numberC)
                {
                    if (numberA > numberC)
                    {
                        Console.WriteLine("Ответ на третье задание: " + numberB + " " + numberA + " " + numberC);
                    }
                    else
                    {
                        Console.WriteLine("Ответ на третье задание: " + numberB + " " + numberC + " " + numberA);
                    }
                }
                else
                {
                    Console.WriteLine("Ответ на третье задание: " + numberC + " " + numberB + " " + numberA);
                }
            }

            // 4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где A*X*X+B*X+C=0.
            Console.WriteLine("Задание №4");
            Console.WriteLine("Введите число A");
            double numberA4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double numberB4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C");
            double numberC4 = Convert.ToDouble(Console.ReadLine());

            double numberX1;
            double numberX2;

            double numberDiskriminant = numberB4 * numberB4 - 4 * numberA4 * numberC4;
            Console.WriteLine(numberDiskriminant);
            if (numberDiskriminant > 0)
            {
                numberX1 = (-numberB4 + Math.Sqrt(numberDiskriminant)) / (2 * numberA4);
                numberX2 = (-numberB4 - Math.Sqrt(numberDiskriminant)) / (2 * numberA4);
                Console.WriteLine("Ответ на четвертое задание: X1 = " + numberX1 + ", X2 = " + numberX2);
            }
            else if (numberDiskriminant == 0)
            {
                numberX1 = -numberB4 / (2 * numberA4);
                Console.WriteLine("Ответ на четвертое задание: X = " + numberX1);
            }
            else
            {
                Console.WriteLine("Ответ на четвертое задание: корней нет.");
            }


            // 5. Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
            Console.WriteLine("Задание №5");
            Console.WriteLine("Введите двухначное число");
            int numberDvuhznachnoe = Convert.ToInt32(Console.ReadLine());

            int numberOstatok = numberDvuhznachnoe % 10;
            int nummberDesyatok = numberDvuhznachnoe / 10;

            String propis1 = " один";
            String propis2 = " два";
            String propis3 = " три";
            String propis4 = " четыре";
            String propis5 = " пять";
            String propis6 = " шесть";
            String propis7 = " семь";
            String propis8 = " восемь";
            String propis9 = " девять";
            String propis10 = "Десять";
            String propis20 = "Двадцать";
            String propis30 = "Тридцать";
            String propis40 = "Сорок";
            String propis50 = "Пятьдесят";
            String propis60 = "Шестьдесят";
            String propis70 = "Семьдесят";
            String propis80 = "Восемьдесят";
            String propis90 = "Девяносто";

            if (nummberDesyatok == 1)
            {

            }

        }
    }
}
