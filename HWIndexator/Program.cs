using MyArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWIndexator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            MyArr array = new MyArr(3);
            array[0] = 4;
            array[1] = 134;
            array[2] = 1000;

            for (int i = 0; i < array.Size; i++)
            {
                Console.Write("{0}. {1} * {2} = {3}",i+1,Math.Sqrt(array.GetElem(i)), Math.Sqrt(array.GetElem(i)), array[i]);
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }
    }
}
