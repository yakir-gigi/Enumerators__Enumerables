using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators__Enumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[10];
            int temp = 0;
            for (int i = 10; i <=100; i+=10)
            {
                
                 array[temp]= i ;
                temp++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            foreach (var item in array)
            {

            }
           
        }
    }
}
