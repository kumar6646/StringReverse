using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string a = Console.ReadLine();
            string b = null;
            for(int i=a.Length-1;i>=0;i--)
            {
                b = b + a[i];
            }
            if(a==b)
            {
                Console.WriteLine("it is palindrom");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
               
        }
    }
}
