namespace Takrorolash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter number: ");
            int son= int.Parse(Console.ReadLine());

            Console.WriteLine(" Raqamlari yigindisi: "+Xonalaryigindisi(son));

        }
        public static int Xonalaryigindisi(int son)
        {
            int sonyigindisi = 0;
            while (true)
            {
                if (son > 0)
                {
                    sonyigindisi += son % 10;
                    son = son / 10;
                }
                else
                {
                    return sonyigindisi; 
                }

            } 
        }
    }
}