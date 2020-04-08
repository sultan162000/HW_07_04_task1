using System;
using Class1;

namespace ProgramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5,6};
            
            Console.WriteLine(ArrayHelper.UnShift(ref a,7));
            foreach (var item in a)
            {
                System.Console.Write(item+" ");
            }
            

        }
    }

}
