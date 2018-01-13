using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazes
{
   public  class Mazes
    {
       public static char[,] lab =
{
      {' ', ' ', ' ', '*', ' ', ' ', ' '},
      {'*', '*', ' ', '*', ' ', '*', ' '},
      {' ', ' ', ' ', ' ', ' ', ' ', ' '},
      {' ', '*', '*', '*', '*', '*', ' '},
      {' ', ' ', ' ', ' ', ' ', ' ', 'е'},
};

        public int[] arrRowColDirection = new int[3];
    //    public char[] arrDir = new char[];
        static char[] path =
              new char[lab.GetLength(0) * lab.GetLength(1)]; 
        static int position = 0;

        public  int [] FindPath(int row, int col, char direction)
        {
            if ((col < 0) || (row < 0) ||
                  (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                
                
                arrRowColDirection[0] = 0;
                arrRowColDirection[1] = 0;
                arrRowColDirection[2] = 0;
                // We are out of the labyrinth
                return arrRowColDirection;
            }

            // Append the direction to the path
            path[position] = direction;
            
            for (int i = 0; i < lab.Length; i++)
            {
             //   direction = arrDir[i];
            }
            position++;

            // Check if we have found the exit
            if (lab[row, col] == 'е')
            {
                PrintPath(path, 1, position - 1);
            }

            if (lab[row, col] == ' ')
            {
                // The current cell is free. Mark it as visited
                lab[row, col] = 's';

                // Invoke recursion to explore all possible directions
                FindPath(row, col - 1, 'L'); // left
                FindPath(row - 1, col, 'U'); // up
                FindPath(row, col + 1, 'R'); // right
                FindPath(row + 1, col, 'D'); // down

                // Mark back the current cell as free
                lab[row, col] = ' ';
            }

            // Remove the direction from the path
            position--;

            arrRowColDirection[0] = row;
            arrRowColDirection[1] = col;
            arrRowColDirection[2] = direction;

            return arrRowColDirection;
        }
      //  public char[] arrDir = new char [];

         public static void PrintPath(
              char[] path, int startPos, int endPos)
        {
            Console.Write("Found path to the exit: ");
            for (int pos = startPos; pos <= endPos; pos++)
            {
                Console.Write(path[pos]);
            }
            Console.WriteLine();
        }

      public  static void Main()
        {
            Mazes maze = new Mazes();
            maze.FindPath(0, 0, 'S');
        
            Console.WriteLine(lab.GetLength(0));
            Console.WriteLine(lab.GetLength(1));

            Console.ReadLine();
        }
    }
}
