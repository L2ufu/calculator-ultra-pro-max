using calculator_ultra_pro_max_super_edition;
using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_ultra_pro_max_super_edition
{
    internal class GUIConsoleApp
{

    internal void Run()
    {

        unitCount calculator = new unitCount();
        ArrayReader arrayReader = new ArrayReader();
        string stop = "";
        while (stop != "Нет")
        {
            Console.WriteLine("Выбирите с чем работать \n  1 - + \n 2 - - \n 3 - * \n 4- / \n 5 - ! \n 6 - % \n 7 - d%\n 8 - mod\n 9 - min\n 10 - max \n 11 - посчитать количество \n 12 - посчитать сумму \n 13 - сортировка массива по возрастанию");
            string choise1 = Console.ReadLine();

            switch (choise1)
            {
                case "1":
                        Console.WriteLine("Введите число 1:");
                        var num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число 2:");
                        var num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.sum(num1, num2));
                        break;


                case "2":
                        Console.WriteLine("Введите число 1:");
                        var num3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число 2:");
                        var num4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.substruction(num3, num4));
                        break;

                case "3":
                        Console.WriteLine("Введите число 1:");
                        var num5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число 2:");
                        var num6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.mult(num5, num6));

                        break;


                case "4":
                        Console.WriteLine("Введите число 1:");
                        var num7 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число 2:");
                        var num8 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.deploy(num7, num8));

                        break;
                case "5":
                        Console.WriteLine("Введите число:");
                        var num9 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.factorialCount(num9));
                        break;


                case "6":
                        Console.WriteLine("Введите число 1:");
                        var num10 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число 2:");
                        var num11 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.procentCount(num10, num11));

                        break;

                case "7":
                        Console.WriteLine("Введите число 1:");
                        var num12 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число 2:");
                        var num13 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.deProcentCount(num12, num13));

                        break;


                case "8":
                        Console.WriteLine("Введите число 1:");
                        var num14 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число 2:");
                        var num15 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ:");

                        Console.WriteLine(calculator.remainderDivisionCount1(num14, num15));
                        Console.WriteLine(calculator.remainderDivisionCount2(num14, num15));

                    break;


                case "9":
                        double[] Array0 = arrayReader.InputArray();
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.minNumber(Array0));

                        break;


                case "10":
                        double[] Array1 = arrayReader.InputArray();
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.maxNumber(Array1));

                        break;
                case "11":
                        double[] Array2 = arrayReader.InputArray();
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.arrayCount(Array2));
                        break;


                case "12":
                        double[] Array3 = arrayReader.InputArray();
                        Console.WriteLine("Ответ:");
                        Console.WriteLine(calculator.arraySum(Array3));
                        break;

                case "13":
                        double[] Array4 = arrayReader.InputArray();
                        double[] sorted = calculator.arraySort(Array4);
                        Console.WriteLine("Ответ: ");
                        foreach (double number in sorted)
                        {
                            Console.Write(number + " ");
                        }
                        break;


            }
                


            Console.WriteLine("\n Хотите посчитать новый пример? Да/Нет");
            stop = Console.ReadLine();
        }
    }
}
}