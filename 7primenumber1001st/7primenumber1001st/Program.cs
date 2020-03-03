using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7primenumber1001st
{
    internal class Program
    {
         static internal  List<int> prime = new List<int>();
         //static int[] parray = new int[10006];
        //internal static int prime;
        private static int i;
        static private int[] k = new int[200001];
        static private int f = 1;
        static void Main(string[] args)
        {

             //IsPrime();
            IsPrime();
            //if(IsPrime())
            //{
                
          
            //    Console.WriteLine("{0} is prime", prime);
                
            //}

            Console.ReadKey();
        }




        static void IsPrime()
        {
            for ( i = 2; i <= 200000; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i == 2)
                    {
                        i++;
                    }

                    if (i % j == 0)
                    {
                        //Console.WriteLine("{0} is not Prime", i);
                        i++; 
                       // j--;
                        j = 2;
                    }

                    else if (i % j != 0)
                    {
                        //  j --;
                        // break;
                       // j++;
                       continue;
                    }

                }

               // Console.WriteLine("{0} is prime", i);

                if (i != 0)
                {
                    
                    k[f] = i;
                   
                    //Console.WriteLine("the {0}", k[f]);
                    f++;
                }
                 
            }

            Console.WriteLine("The Primes are:");
            for ( f = 1; f <=10001; f++)
            {
                if(k[f] != 0)
                {
                     Console.WriteLine("The {0} th prime is {1}",f,k[f]);
                }

                //if (f == 10001)
                //{
                //    Console.WriteLine("The {0} prime is: {1}", f, k[f]);
                //    break;
                //}
                //if (f == 10000)
                //{
                //    Console.WriteLine("The {0} prime is: {1}", f, k[f]);

                //}
            }

        }
           

      
       
    }
}




    

