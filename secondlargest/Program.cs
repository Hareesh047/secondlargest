using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondlargest
{
     class Program
    {
        public static void secondlargest(int[] a,int n)
        {
            int i, largest, secondlargest;

            if (n < 2)
            {
                Console.WriteLine("Invalid size");
                return;
            }

            largest=secondlargest=int.MinValue;
            for (i = 0; i < n; i++)
            {
                if (a[i] > largest)
                {
                    secondlargest = largest;
                    largest = a[i];
                }

                else if (a[i] > secondlargest && a[i] != largest)

                    secondlargest = a[i];
            }
            

                if (secondlargest == int.MinValue)
                    Console.WriteLine("No Second Largest number in this array");

                else
                
                    Console.WriteLine("The second largest Number is :"+secondlargest);   

        }



        static void Main(string[] args)
        {
            int[] a = new int [6];
            int i;
            int n = a.Length;
            
            Console.WriteLine("enter the elements of an array :");

            for(i=0;i < 6; i++)
            {
                Console.WriteLine("");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in array are: ");
            for (i = 0; i < 6; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.WriteLine();
            secondlargest(a, n);
            Console.ReadLine();
        }
    }
}
