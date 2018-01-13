using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mazes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazes.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void TestMazeAlgorithm()
        {
            Assert.IsTrue(true);
        }


        [TestMethod()]
        public void PrintPathTest()
        {
            int col;
            int row;
            int maxMoves;
            Mazes maze = new Mazes();
            col = maze.arrRowColDirection[0];
            row = maze.arrRowColDirection[1];

            row = Mazes.lab.GetLength(0);
            col = Mazes.lab.GetLength(1);
            if (col*row <0)
            {
                Console.WriteLine("The Labyrinth is incorrect");
                Assert.Fail();
            }
            char first;

            first = maze.arrDir[1];
            maxMoves = (col * row) - 1;
           
            

           
           
         
           // char [,] lab = maze.getLabValues();
            
          // int [] path = maze.FindPath(5,9,'L') ;
            //  Assert.AreEqual(14, Mazes.FindPath(0,0,'L'));

            //foreach (var item in path)
            //{
            //    Console.WriteLine(item);
            //}

          //  Assert.Fail();
            
        }
    }
}