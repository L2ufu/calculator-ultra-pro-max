using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_ultra_pro_max_super_edition
{
    internal class ArrayReader
    {
        #region Obtaining an array
        internal double[] InputArray()
        {
            Console.WriteLine("Введите количество элементов:");
            var count = int.Parse(Console.ReadLine());
            double[] array = new double[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите число:");
                array[i] = double.Parse(Console.ReadLine());
            }
            return array;
        }
        #endregion
    }
}
