using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_ultra_pro_max_super_edition
{
    internal class unitCount
    {
        #region calculation of the sum
        internal double sum(double num1, double num2) 
        {
            return (num1 + num2);
        }
        #endregion

        #region subtraction
        internal double substruction(double num1, double num2)
        {
            return (num1 - num2);
        }
        #endregion

        #region multiplication
        internal double mult(double num1, double num2)
        {
            return (num1 * num2);
        }
        #endregion

        #region divide
        internal double deploy(double num1, double num2)
        {
            return (num1 / num2);
        }
        #endregion

        #region calculating percentages of numbers
        internal double procentCount(double numP1, double numP2) 
        {
            return ((numP1 / 100) * numP2);
        }
        #endregion

        #region reverse calculation of percentages from numbers
        internal double deProcentCount(double numDP1, double numDP2) 
        {
            return ((numDP1 * 100)/numDP2);
        }
        #endregion

        #region factorial
        internal double factorialCount(double numIC1) 
        {
            double result = 1;
            for (double i = 2; i<= numIC1; i++) 
            {
                result = result * i;
            }
            return result;
        }
        #endregion

        #region integer division + remainder division 
        internal int remainderDivisionCount1(int numRDC1, int numRDC2) 
        {
            
            return (numRDC1 / numRDC2);
            
        }
        internal int remainderDivisionCount2(int numRDC1, int numRDC2)
        {
            return  (numRDC1 % numRDC2);
            

        }
        #endregion

        #region array maximum number count
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
        #endregion

        #region array minimum number count
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
        #endregion

        #region array sum
        internal double arraySum(double[] array)
        {
            double sum = 0;
            foreach (var x in array) sum += x;
            return sum;
        }
        #endregion

        #region array quantities and numbers
        internal double arrayCount(double[] array)
        {
            return array.Length;

        }
        #endregion

        #region array sort
        internal double [] arraySort(double[] array) 
        {
            for (int i = 0; i<array.Length - 1; i++) 
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        double a = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = a;

                    }
                }
                
            }
            return array;
        }
        #endregion
    }
}

