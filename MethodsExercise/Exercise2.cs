using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class Exercise2
    {
        //public static int Add(int num1, int num2)
        //{ 
        //    return num1 + num2;
        //}

        public static int Add(params int[] numbers) //Params keyword allows any number of integers to be passed into an array called numbers.
        {
            int sum = 0; //Makes variable sum and sets to 0. 0 is the identity element for addition, ie, always set sum to 0 initially; Will add sum of integers passed in;
            foreach (int num in numbers) //Declares integer variable named num to represent elements in numbers array in line 18.
            {
                sum += num; //Adds value of num to sum variable during each loop
            }
            return sum;        
        }

        //}
        //public static int Multiply(int num1, int num2)
        //{
        //    return num1 * num2;


        public static int Multiply(params int[] numbers) //Params keyword allows any number of integers to be passed into an array called numbers.
        {
            int product = 1; //Makes variable product and sets to 1. 1 is the identity element for multiplication, ie, always set product to 1 initially; Will multiply integers passed in.
            foreach (int num in numbers) //Declares integer variable num to represent elements in numbers array from line 34.
            {
                product *= num; //Multiplies the value of num with the current value of product during each iteration of the loop.
            }
            return product;
        }
        
        //public static int Subtract(int num1, int num2) 
        //{
        //    return num1 - num2;
        //}

        public static int Subtract(params int[] numbers) //Params keyword allows any number of integers to be passed into an array called numbers.
        {
            int result = numbers[0]; //Initializes result variable with the first item in the numbers array. Subtraction always starts with the first number in the array [0].
            for (int i = 1; i < numbers.Length; i++) //starts I at the second item in the numbers array [1] and will continue until I is less than the length of numbers array.
            {
                result -= numbers[i]; //Subtracts values of numbers[i] from current value of result for each iteration; Subtracts all numbers in the numbers array from the initial value [0].
            }
            return result;
        }

        //public static int Divide(int num1, int num2)
        //{
        //    return num1 / num2;

        public static int Divide(params int[] numbers) //Params keyword allows any number of integers to be passed into an array called numbers.
        {
            int quotient = numbers[0]; //Sets variable quotient to the zero index of the numbers array. Just like subtraction, division starts with the first number [0].
            for(int i = 1;i < numbers.Length; i++) //Starts I at the second number in the array [1] and will continue until I is less than the length of the array.
            {
                quotient /= numbers[i]; //Divides the current value of quotient with the current value of numbers[i] during each iteration of the loop. Divides all numbers in the array by the initial value [0].
            }
            return quotient;
        }
    }
}
