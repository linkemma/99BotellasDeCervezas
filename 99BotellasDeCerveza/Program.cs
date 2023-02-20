using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99BotellasDeCerveza
{
    internal class Program
    {
        static string singleWord = "bottle";
        static string pluralWord = "bottles";
        static string text = "{0} {2} of beer on the wall, {0} {2} of beer \n" +
            "Take one down and pass it around, {1} {3} of beer on the wall\n\n";
        static string end = "No more bottles of beer on the wall, no more bottles of beer \n" +
            "Go to the store and buy some more, 99 bottles of beer on the wall";
        static string zeroBeer = "no more";
        static void Main(string[] args)
        {
            for(int i = 99; i > 0; i--)
            {
                print(i);
            }
            Console.WriteLine(end);
        }
        static void print(int num)
        {
            Console.WriteLine(text, 
                              num, 
                              (num-1), 
                              (num ==1 ? singleWord: pluralWord),
                              (num - 1 == 1 ? singleWord : pluralWord));
        }
    }
}
