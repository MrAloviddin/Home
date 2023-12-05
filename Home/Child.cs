using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class Child
    {
        private string name = "Aloviddin";
        private int age = 14;


        public Child(string name, int age)
        {
            name = name; age = age;

        }
        
        public string Name
        {
            get { return name; } 
        }
        public int Age
        { 
            get { return age; } 
        }


    }
}
