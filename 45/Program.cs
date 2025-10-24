using System;

namespace inl45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                int x = Int32.Parse(input.Substring(i,1));
               
                if(x == 9)
                {
                    x = 0;
                }
                else
                {
                    x += 1;
                }

                    Console.Write(x);
            }
        }
    }
}