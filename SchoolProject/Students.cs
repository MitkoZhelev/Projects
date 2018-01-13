using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Students : Name
    {
        private int number;
        private int uniqueID;
        public int getNumber()
        {
            return this.number;
        }
        public void setNumber(int value)

        {
            if (value >= 0)
            {
                this.number = value;

            }
            else
            {
                Console.WriteLine("Invalid Input ");
            }

        }
        public int getID()
        {
            return this.uniqueID;
        }
        public void setID (int value)
        {
            if (value > 0)
            {
                this.uniqueID = value;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }


    }
}
