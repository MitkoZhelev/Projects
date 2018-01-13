using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Teachers : Name
    {
        private string teacherClasses;
        public string getClasses ()
        {
            return this.teacherClasses;
        }
        public void setClasses (string value)
        {
            if (value.Length > 0)
            {
                this.teacherClasses = value;

            }
            else
            {
                Console.WriteLine("Invalid Parameters");
            }
        }
    }
}
