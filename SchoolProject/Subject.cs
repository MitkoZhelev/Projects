using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Subject
    {
        private string subjects;
        public string getSubj ()
        {
            return this.subjects;
        }
        public void setSubj (string value)
        {
            if (value.Length > 0)
            {
                this.subjects = value;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

                
        }

    }
}
