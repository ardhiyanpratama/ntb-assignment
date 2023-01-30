using FizzApps.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzApps.Core.Repository
{
    public class FizzRepository : IFizzRepository
    {
        public FizzRepository()
        {

        }
        public async Task<string> Fizz(int sequence)
        {
            var result = " ";
            for (int i = 1; i <= sequence; i++)
            {

                // Number divisible by 15(
                // divisible by both 3 & 5),
                // print 'FizzBuzz' in place
                // of the number
                if (i % 15 == 0)
                {
                    Console.Write("FizzBuzz" + " ");
                    result += "FizzBuzz" + " ";
                }
                // Number divisible by 3,
                // print 'Fizz' in place
                // of the number
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz" + " ");
                    result += "Fizz" + " ";
                }
                // Number divisible by
                // 5, print 'Buzz'
                // in place of the number
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz" + " ");
                    result += "Buzz" + " ";
                }
                // Print the numbers
                else
                {
                    Console.Write(i + " ");
                    result += i + " ";
                }   
            }

            return result;
        }
    }
}
