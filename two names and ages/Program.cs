using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_names_and_ages
{
    internal class Program
    {
        public static int combined;
        public static int age1;
        public static int age2;
        static void Main(string[] args)
        {
            Question Q1 = new Question("what is your name: ");
            Q1.response();
            Question Q2 = new Question("What is your age: ");
            Q2.response();
            age1 = int.Parse(Q2.response());
            Question Q3 = new Question("what is your name: ");
            Q3.response();
            Question Q4 = new Question("What is your age: ");
            Q4.response();
            age2 = int.Parse(Q2.response());
            combined = age1 + age2;
            Console.WriteLine(combined);
            Console.ReadKey();
        }
    }
}
