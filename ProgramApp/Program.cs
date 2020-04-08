using System;
using Class1;

namespace ProgramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {7,2,3,4,5,6};

            ArrayHelper.Shift(ref a);
            foreach (var item in a)
            {
                System.Console.Write(item+" ");
            }
            
            Console.WriteLine(ArrayHelper.UnShift(ref a,1));
            foreach (var item in a)
            {
                System.Console.Write(item+" ");
            }
            System.Console.WriteLine();



            string[] userName = {"Google","Amazon","Пятёречка"};

            Console.WriteLine(ArrayHelper.Pop(ref userName));
            foreach (var item in userName)
            {
                System.Console.Write(item+" ");
            }
            System.Console.WriteLine();
            ArrayHelper.Push(ref userName,"Microsoft");
            foreach (var item in userName)
            {
                System.Console.Write(item+" ");
            }


            

        }
    }

}
