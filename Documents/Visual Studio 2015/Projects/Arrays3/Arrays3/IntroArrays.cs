using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    class IntroArrays
    {

        public static void Main()
        {


            //polynoms

            string str = "(3x2 + x2 - 3)";

            int powCounter = 0;
            int [] arrPow = new int[10];
            if (str.Contains("x"))
            {
                char[] charArr = str.ToCharArray();

                for (int i = 0; i < charArr.Length; i++)
                {
                    if ( (++i < charArr.Length - 1) && (charArr[i] == 'x' || Char.IsDigit(charArr[i++])))
                    {
                        int pow = charArr[i++] & 0x0f;//(int)Char.GetNumericValue(charArr[i++]);
                        Console.WriteLine(charArr[i++]);
                        arrPow[powCounter] = pow;
                    }
                }
            }

            foreach (var item in arrPow)
            {
               // Console.WriteLine(item);
            }
            Console.WriteLine("After");
            //multidimensional arrays


            string[,] arr = new string[5, 3];

            //jagged array

            int[][] jaggedArr = new int[5][];

            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];
            int inc = 0;

            //matrix.GetLength(0) - rows
            //matrix.GetLength(1) - cols

            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = ++counter;
                 
                }
            }

            int count = 1;
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {

                /****
                ****
                0,0| 1,3 | 2,0| 3,3
                */

               

                for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                           
                            
                          Console.Write(matrix[j, i]);
                    count++;
                    if (count % 2 == 0)
                    {
                            for (int p = matrix.GetLength(1) - 1; p > 0; p--)
                            {


                                Console.Write(matrix[i++, p]);

                            }

                        }

                }
              
                  
               
                Console.WriteLine();
               
            }

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


        private static int[] reverseArr(int row, int inc)
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

    }
}
