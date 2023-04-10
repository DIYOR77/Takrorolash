namespace Takror
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter number: ");
            string srt = Console.ReadLine();
            Son(srt);
            Main(args);

        }
        public static void Son(string str)
        {
            string satr = "";
            int j = 0;
            for (int i = str.Length - 1; i > -1; i--, j++)
            {
                if (j % 3 == 0 && j > 0)
                {
                    satr = str[i] + "," + satr;
                }
                else
                {
                    satr = str[i] + satr;
                }
            }
            Console.WriteLine(satr);


        }
    }
}