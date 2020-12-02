using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ContentControl.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            FirstName = "Klaus";
            LastName = "Nørregaard";
        }
        //public override string ToString()
        //{
        //    return FirstName + " " + LastName;
        //}
    }
  
}
