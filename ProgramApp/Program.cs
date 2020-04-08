using System;
using Class1;

namespace ProgramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5,6,7};
            
            Console.WriteLine(ArrayHelper.Shift(ref a));
            foreach (var item in a)
            {
                System.Console.Write(item+" ");
            }
            

        }
    }

}
