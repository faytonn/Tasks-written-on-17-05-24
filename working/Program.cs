using System.ComponentModel.Design;
using System.Globalization;

namespace working
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // /* Task 1 * -> FIBONACCI SEQUENCE/
            ////0,1,1,2,3,5,8,13,21,34,55,89,144,
            //int x = 0;
            //int y = 1;

            //// (n-1) + (n-2)
            //Console.Write(x + ",");
            //Console.Write(y + ",");

            //while (true)
            //{
            //    int z = x + y;
            //    Console.Write(z);
            //    x = y;
            //    y = z;
            //  Console.ReadLine();
            //}




            /* Task 2 * -> ADLARIN PRINT OLUNMASI/
            //string[] names = {"Asiman", "Ismayil", "Musa"};
            //int i = 0;

            //while(true)
            //{
            //    if (i < names.Length)
            //    {
            //        Console.WriteLine(names[i]);
            //        i++;
            //    }


            /* Task 3 * -> MAXIMUMUN TAPILMASI/
            //int[] numbers = { 21, 31, 32, 1, 3, 213, 12, 231 };
            //int max = numbers[0];
            //int i = 0;
            //while (i < numbers.Length)
            //{
            //    if (numbers[i] > max)
            //    {
            //       max = numbers[i];

            //    }
            //    i++;
            //}
            //Console.WriteLine(max);


            /* Task 4 * -> MINIMUMUN TAPILMASI/
            //int[] numbers = { 21, 31, 32, 1, 3, 213, 12, 231 };
            //int min = numbers[0];
            //int i = 0;

            //while (i < numbers.Length)
            //{
            //    if (numbers[i] < min)
            //    { 
            //        min = numbers[i];
            //    }
            //    i++;
            //}

            //Console.WriteLine(min);


            ///* Task 5 * -> ????????/
            //int[] numbers = { 21, 31, 32, 1, 3, 231, 12, 1 };
            //int min = numbers[1];
            //int max = numbers[0];
            //int i = 1;

            //while (i < numbers.Length)
            //{
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //    else if (numbers[i] > max) 
            //    { 
            //        max = numbers[i];
            //    }
            //    i++;
            //}


            //Console.WriteLine(min);
            //Console.WriteLine(max);


            /* Task 6* - EDEDI ORTANIN TAPILMASI */
            // //ededi orta -> total / numbers.length
            // int[] numbers = { 1, 5, 7, 22, 41, 10, 100, 141 };
            // int i = 0;
            // decimal total = 0M;

            // while (i < numbers.Length)
            // {
            //     total += numbers[i];
            //     i++;
            // }
            //decimal meanAverage = total / numbers.Length;
            // Console.WriteLine(meanAverage);


            /* task 8 -> ARRAYIN TERSINE CEVRILMESI */
            // i-- istifade edilecek

            //int[] number = { 1, 3, 5, 10, 12, 25, 34, 47, 49 };
            //int i = 0;

            /* TASK 9 -> arrayin movcud olub-olmadigini ashkarlamaq*/
            //int[] numbers = { 1, 2, 4, 7, 20, 15 };
            //int i = 0;

            ////Console.WriteLine("Please write a number: " + int.Parse(Console.ReadLine())); 

            //Console.WriteLine("Please write a number: ");
            //int input = int.Parse(Console.ReadLine());
            //bool result=false;
            //while (i < numbers.Length)
            //{
            //    //if ((int.Parse(Console.ReadLine()) == numbers[i])
            //    if (input == numbers[i])
            //    {
            //       result=true;
            //        break;
            //    }

            //    i++;
            //}
            //Console.WriteLine(result);


            /* TASK 10 -> ARRAYLERIN SIRA ILE VERILMESI */
            //int[] number = { 2, 5, 4, 10, 7, 4, 1 };
            //int i = 0;
            //int firstNumber = number[0];

            //bool isSorted = true;

            //while (i < number.Length)
            //{
            //    if (number[i+1] < number[i])
            //    {
            //        isSorted = false;
            //        break;
            //    }
            //   i++;  
            //}
            //Console.WriteLine(isSorted);

           /* TASK 11 -> MAX ILE MIN-IN YERIN DEYISHMEK */
            int[] numbers = { 4, 1, 6, 7, 8, 9 };
            int i = 0;
           
            int max = 0;
            int min = 0;

            while (i < numbers.Length)
            {
                if (max < numbers.Length)
                {
                    max = numbers[i];
                }
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
                i++;
      }
            i = 0;
            while( i < numbers.Length)
            {
                if (numbers[i] == max)
                {
                    numbers[i] = min;
                }
               else if (numbers[i] == min)
                {
                    numbers[i] = max;
                }
            }

            i = 0;

            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + ",");
                i++;
            }

        }
    }
}
