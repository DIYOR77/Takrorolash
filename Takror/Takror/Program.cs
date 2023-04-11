using System.Globalization;

namespace Takror
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter N number: ");
            int N=int.Parse(Console.ReadLine());
            Shakl(N);
        }
        public static void Shakl(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n;j ++)
                {
                    if (i + j < n)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                        
                    
                }
                Console.WriteLine();
            }
        }
    }
}