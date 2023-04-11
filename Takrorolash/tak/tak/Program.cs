namespace tak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter massive size: ");
            int n=int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Ikkinidarajasi(n);
        }
        public static void Ikkinidarajasi(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + Math.Pow(2, i));
            } 
        }
    }
}