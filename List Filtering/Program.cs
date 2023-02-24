using System;
using System.Collections.Generic;

namespace List_Filtering
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> result = new List<int>();

            foreach (var c in listOfItems)
            {
                if (c is int)
                {
                    result.Add((int)c);
                }
            }

            return result;
        }
    }
}
