using System;
using System.Collections.Generic;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNum = new List<int> { 1, 1 };


            //to get the first 20 numbers
            while (fibonacciNum.Count < 20)
            {// the last item
                var previous = fibonacciNum[fibonacciNum.Count - 1];

                //the last second item
                var previous2 = fibonacciNum[fibonacciNum.Count - 2];

                fibonacciNum.Add(previous + previous2);

            }

            //the first 20 numbers
            //for (int i = 1; i < 19; i++)
            //{
            //    // the last item
            //    var previous = fibonacciNum[fibonacciNum.Count - 1];

            //    //the last second item
            //    var previous2 = fibonacciNum[fibonacciNum.Count - 2];

            //    fibonacciNum.Add(previous + previous2);

            //}


            foreach (var item in fibonacciNum)
            {
                Console.WriteLine(item);
            }


        }
    }
}
