using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EssentialTrainingApp
{
    class MainClass
    {
        public static List<string> Words;

        public static void Main(string[] args)
        {
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProblem();
            ReadTextFile();
        }

        public static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch
            {
                Console.WriteLine("Could not file the file");
            }
        }

        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i = 10; i > 0; i--)
            {
                income = income = income / i;
            }

            return income;
        }
    }
}
