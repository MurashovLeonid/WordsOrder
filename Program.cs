using System;
using System.Linq;



namespace ConsoleGeneralTrain
{
    class ArrayAnalyser
    {
        public static string Order(string words)
        {
           return !words.Any()? String.Empty : 
                String.Join(" ", words.Split(' ').OrderBy(i => i.Where(z => !Char.IsLetter(z)).Select(g => g.ToString()).ToArray().First()));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string a = "strin5g 3a 2is Thi1s te4st";
            Console.WriteLine(ArrayAnalyser.Order(a));
        }
    }
}


