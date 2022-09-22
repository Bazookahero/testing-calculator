using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_calculator
{
    public class calc
    {
        public double sum = 0;
        public double Addition(double num1, double num2)
        {
            sum = num1 + num2;
            return sum;
        }
        public double Addition(int[] intArray)
        {
            
            foreach (int num in intArray)
            {
                sum += num;
            }
            return sum;
        }
        public double Subtraction(double num1, double num2)
        {
            sum = num1 - num2;
            return sum;
        }
        public double Subtraction(double[] doubleArray)
        {

            for (int i = 1; i < doubleArray.Length; i++)
            {
                sum = doubleArray[0] -= doubleArray[i];
            }
            return sum;
        }
        public double Multiplication(double num1, double num2)
        {
            sum = (num1 * num2);
            return sum;
        }
        public double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
            sum = num1 / num2;
            return sum;
        }
        public void Reset()
        {
            sum = 0;
        }
    }
}
