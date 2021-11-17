using System;
using System.IO;
namespace RandomQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("49 Wise Quotes That Will Inspire You to Success in Life");
            Console.WriteLine(GetRandomQuote());
        }


        public static string GetRandomQuote()
        {
            string fullfilepath = @"C:\Users\opilane\Samples\quotes.txt";
            string[] RandomQuote = File.ReadAllLines(fullfilepath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, RandomQuote.Length);

            return (RandomQuote[randomIndex]);
        }
    }
}
