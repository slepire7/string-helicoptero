using System;
using System.Threading;

namespace helicoptero
{
    class Program
    {
        static readonly string Helice1 = "*****************->";
        static readonly string Helice2 = "<-*****************";
        static readonly string HeliceEmpty = "                   ";
        static void Main(string[] args)
        {
            ConstruirHelicptero();
        }
        static void ConstruirHelicptero()
        {
            ConstruirHelice();
            NewLine(1);
            ConstruirCorpo();
            UpdateHelice();
            Console.ReadKey();
        }
        static void ConstruirHelice()
        {
            Space(6);
            Console.Write(Helice2);
            Console.Write(" H ");
            Console.Write(Helice1);
        }
        static void TopLine()
        {
            Console.SetCursorPosition(0, 0);
        }
        static void UpdateHelice(int x = 100)
        {

            TopLine();
            WriteLine();
            while (true)
            {
                TopLine();
                Console.Write("{0}", Helice2);
                Console.Write(" H ");
                Console.Write("{0}", HeliceEmpty);
                Thread.Sleep(100);
                TopLine();
                Console.Write("{0}", HeliceEmpty);
                Console.Write(" H ");
                Console.Write("{0}", Helice1);
                Thread.Sleep(100);
            }
        }
        static void ConstruirCorpo()
        {

            string part1 = "/--------------------";
            string part2 = @"LOL==========               [  ] \";
            string part3 = @"\                      \";
            string part4 = @"\                       \";
            string part5 = @"[_______________________]";
            string part6 = "T          T";
            string part7 = @"\------------------------/";
            Space(15);
            WriteLine(part1);
            Space(3);
            WriteLine(part2);
            Space(15);
            WriteLine(part3);
            Space(16);
            WriteLine(part4);
            Space(17);
            WriteLine(part5);
            Space(24);
            WriteLine(part6);
            Space(17);
            WriteLine(part7);
        }
        private static void WriteLine(string value = "                                               ")
        {
            Console.WriteLine(value);
        }
        static void Space(int s)
        {
            for (int i = 0; i < s; i++)
            {
                Console.Write(" ");
            }
        }
        static void NewLine(int n)
        {
            for (int i = 0; i < n; i++)
            {
                WriteLine(" ");
            }
        }
    }
}
