using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_ultra_pro_max_super_edition
{
    internal class unitCount
    {
        internal double sum(double num1, double num2) 
        {
            return (num1 + num2);
        }
        internal double substruction(double num1, double num2)
        {
            return (num1 - num2);
        }
        internal double mult(double num1, double num2)
        {
            return (num1 * num2);
        }
        internal double deploy(double num1, double num2)
        {
            return (num1 / num2);
        }

        internal double procentCount(double numP1, double numP2) 
        {
            return ((numP1 / 100) * numP2);
        }

        internal double deProcentCount(double numDP1, double numDP2) 
        {
            return ((numDP1 * 100)/numDP2);
        }

        internal double factorialCount(double numIC1) 
        {
            double result = 1;
            for (double i = 2; i<= numIC1; i++) 
            {
                result = result * i;
            }
            return result;
        }

        internal int remainderDivisionCount(int numRDC1, int numRDC2, out int remainder) 
        {
            remainder = (numRDC1 % numRDC2);
            return (numRDC1 / numRDC2);
            
        }
    }

    internal class ArrayCount
    {
        internal double maxNumber(double[] numbers)
        {

            double maxNumber = numbers[0];
            foreach (double elem in numbers)
            {
                if (maxNumber < elem)
                {
                    maxNumber = elem;
                }
            }
            return maxNumber;
        }

        internal double minNumber(double[] numbers)
        {

            double minNumber = numbers[0];
            foreach (double elem in numbers)
            {
                if (minNumber > elem)
                {
                    minNumber = elem;
                }
            }
            return minNumber;
        }

        internal double arraySum(double[] array)
        {
            double sum = 0;
            foreach (var x in array) sum += x;
            return sum;
        }

        internal double arrayCount(double[] array)
        {
            return array.Length;

        }
    }
}

