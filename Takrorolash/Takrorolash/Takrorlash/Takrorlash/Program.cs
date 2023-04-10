namespace Takrorlash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a number: ");
            int son1=int.Parse(Console.ReadLine());
            Console.Write(" Enter b number: ");
            int son2=int.Parse(Console.ReadLine());
            Tubson(son1 , son2);
        }
        public static void Tubson(int son1, int son2)
        {
            for(;son1 < son2; ++ son1)
            {
                int buluvchilar = 0;
                for(int i = 1; i < son1;++i)
                {
                    if (son1 % i == 0)
                    {
                        buluvchilar++;
                    }
                }
                if(buluvchilar == 1)
                {
                    Console.Write(" " + son1);
                }
            }
        }
    }
}