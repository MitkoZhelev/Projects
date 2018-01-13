using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Name
    {
        string teachName;
        private string studentName;
        private string subjName;
        public string getName ()
        {
            return this.teachName;
        }
        public void setName (string value)
        {
            if (value.Length > 0 )
            {
                this.teachName = value;
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }
        
        public string getStud ()
        {
            return this.studentName;

        }

        public void setStud (string value)
        {
            if(value.Length > 0)
            {
                this.studentName = value;
            }
            else
            {
                Console.WriteLine("Invalid Value");

            }
        }

        public string getSubj ()
        {
            return this.subjName;
        }
        public void setSubj (string value)
        {
            if (value.Length > 0)
            {
                this.subjName = value;
            }
            else
            {
                Console.WriteLine("Invalid Parameters");
            }
        }


    }
}
