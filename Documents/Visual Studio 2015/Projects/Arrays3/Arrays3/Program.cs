using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Arrays3
{

   class Program
   {

       static void Main(string[] args)
       {
           int row;
           int col;
           ArrayList arr = new ArrayList();



           Console.WriteLine("Enter how many elements");
           row = int.Parse(Console.ReadLine());
           col = row;
           int arrMax = row; 
           int[,] arr1 = new int[row, col];

           int[] rowPrint = new int[row*row];
           int[] colPrint = new int[row*row];

           //for (int i1 = 0; i1 < row; i1++)
           //{
           //    for (int i2 = 0; i2 < col; i2++)
           //    {
           //        arr1[i1, i2] = int.Parse(Console.ReadLine());
           //    }
           //}

           int[][] arr2= new int[3][3];

           int inc = 0;
           int number = ((row * row) / 2) - 1;
           Console.WriteLine("Number is :" + number);

           for (int i = 1; i <= row; i++)
           {


               if (i%2 == 0 )
                {
                   inc += row;
                   rowPrint = reverseArr(row, inc);
                 }
                   else
                 {

                   colPrint =  printArr(row, inc);
                   inc += row;
               }


           }

           for (int i = 0; i < row*2; i++)
           {
               Console.WriteLine(rowPrint[i]);
           }

           int test = 0;
          // int[] numbers = arr.ToArray(typeof(int)) as int[];

           int[] res = arr.OfType<int>().ToArray();
           Console.WriteLine(res.Length);
           foreach (var item in res)
           {
              // Console.WriteLine(item);
               Console.WriteLine(item);
           }

           //for (int i1 = 0; i1 < col; i1++)
           //{
           //    for (int i2 = 0; i2 < row; i2++)
           //    {
           //        arr1[i1, i2] = int.Parse(Console.ReadLine());
           //        if (i1 == row  )
           //        {
           //            for (int i = row; i <= 0; i--)
           //            {

           //            }
           //        }
           //    }
           //}

       }

       private static int [] reverseArr(int row, int inc)
       {
           int increment = inc;
           int[] arr = new int[row];
           for (int i = row - 1; i >= 0; i--)
           {
               //Console.WriteLine(increment);
               arr[i] = increment;
               --increment;
           }

           return arr;
       }

       private static int[] printArr(int row, int inc)
       {
           int increment = inc;
           int[] arr = new int[row];
           for (int i = 0; i < row; i++)
           {

              // Console.WriteLine(++increment);
               arr[i] = increment;
           }
           return arr;
       }
   }

}
*/
