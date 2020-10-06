using System;
using System.Collections.Generic;

namespace interestingNumber
{
    /*
    This program is a proof of 2592 is the only number which has a property like a^b*c^d = abcd.
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listA = new List<int>()
            {
                0,1,2,3,4,5,6,7,8,9
            };

            List<int> listB = new List<int>()
            {
                0,1,2,3,4,5,6,7,8,9
            };

            List<int> listC = new List<int>()
            {
                0,1,2,3,4,5,6,7,8,9
            };

            List<int> listD = new List<int>()
            {
                0,1,2,3,4,5,6,7,8,9
            };

            foreach (var a in listA)
            {
                foreach (var b in listB)
                {
                    foreach (var c in listC)
                    {
                        foreach (var d in listD)
                        {
                            var result = Math.Pow(a, b) * Math.Pow(c, d);
                            var abcd = a.ToString() + b.ToString() + c.ToString() + d.ToString();
                            var abcdConverted = Convert.ToInt32(abcd);
                            if (result == abcdConverted)
                            {
                                Console.WriteLine("result for " + a.ToString() + "^" + b.ToString() + "*" + c.ToString() + "^" + d.ToString());
                                Console.WriteLine(result);
                            }
                        }
                    }
                }
            }
        }
    }
}


