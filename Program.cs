using System;

namespace learning_collections_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] firstname = { 1, 1, 2, 23, 3, 3, 3, 3, 3 };
            //firstname[0] = 19;
            //firstname[2] = 200;
            //firstname[3] = 400;
            //firstname[5] = 40000;
            foreach (int item in firstname)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
