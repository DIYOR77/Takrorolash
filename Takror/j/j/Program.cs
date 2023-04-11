using System.ComponentModel;

namespace j
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter number: ");
            string str=Console.ReadLine();
            if(int.TryParse(str, out int raqam))
            {
                //RaqamlarningxonalridagiSonlarniAniqlash(raqam);
                KiritilganSonningBIrinchivaOxirgiraqaminianiqlash(raqam);
            }
            else
            {
                Console.WriteLine(" Faqat butun son kirita olsiz !!!");
                    
                Main(args);
            }
        }
        //public static void RaqamlarningxonalridagiSonlarniAniqlash(int raqam)
        //{
        //    int xona = 0;
        //    int xonaraqam = 1;
        //    while (true)
        //    {
        //        if (raqam > 0)
        //        {
        //            xona = raqam % 10;
        //            Console.WriteLine(xonaraqam + " lar xonasidagi son " + xona);
        //            raqam = raqam / 10;
        //            xonaraqam = xonaraqam * 10;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //}


        public static void KiritilganSonningBIrinchivaOxirgiraqaminianiqlash(int raqam) 
        {

            string str = raqam.ToString();
            Console.WriteLine(str[0]);
            Console.WriteLine(str[str.Length-1]);
            Console.WriteLine($"{" Orasidagi farq :"}{str[0]}-{str[str.Length - 1]} ={str[0] - str[str.Length-1]}");

            int max = 0;
            int min = str[0];
            for(int i = 0; i < str.Length; i++)
            {
                if (max < str[i])
                {
                    max = str[i];   
                }
                else if (min > str[i])
                {
                    min = str[i];
                }
            }
            Console.WriteLine(" Max: " + (max-48));
            Console.WriteLine(" Min: " +( min-48));
            Console.WriteLine($"{" Orasidagi farqi: "}{max-48}-{min-48}={(max-48)-(min-48)}");



        }



    }
}