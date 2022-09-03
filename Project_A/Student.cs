using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Student
    {
        //Declaration of Attributes/Properties
        
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }

        public string toString()
        {
            return Id + " " + Firstname + " " + Lastname + " " + Address + " " + ContactNumber;
        }
    }
}
