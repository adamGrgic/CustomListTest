using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> testList = new CustomList<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            testList.Add(10);
            testList.Add(11);
            testList.Add(12);

            testList.Remove(3);

            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(testList[i]);
            }

        }
    }
}
