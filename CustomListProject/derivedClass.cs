using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class derivedClass : CustomList<int>

    {
        // Member Variables 


        // Constructors 


        // Methods 
        new public void ToString()
        {
            Console.WriteLine("This is a test to override the ToString Method.");
        }
    }
}
