using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        public static void Main()
        {

            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> num = new List<int>();
            if (first.Count > second.Count && first.Count >= 0)
            {
                for (int i = 0; i < first.Count - 2; i++)
                {
                    for (int j = second.Count - 1; j >= 0; j--)
                    {
                        first.Add(second[j]);
                        Console.WriteLine(string.Join(" ", first));
                       

                    }
                    break;
                }
                
            }
            Console.WriteLine(string.Join(" ", first));

            

        }

    }
}
