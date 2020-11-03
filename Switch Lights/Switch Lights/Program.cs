using System;

namespace Switch_Lights
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] separator= { "turnover $", ", purchase value $" };
            String input;
            String[] arr;

            float purchase1=0;
            float turnover1=0;

            float purchase2=0;
            float turnover2=0;

            float purchase3=0;
            float turnover3=0;
            int count = 2;
            try
            {
                input = Console.ReadLine();
                arr=input.Split(separator, count,StringSplitOptions.RemoveEmptyEntries);
                purchase1 = Convert.ToInt32(arr[1]);
                turnover1 = Convert.ToInt32(arr[0]);

                input = Console.ReadLine();
                arr = input.Split(separator, count, StringSplitOptions.RemoveEmptyEntries);
                purchase2 = Convert.ToInt32(arr[1]);
                turnover2 = Convert.ToInt32(arr[0]);

                input = Console.ReadLine();
                arr = input.Split(separator, count, StringSplitOptions.RemoveEmptyEntries);
                purchase3 = Convert.ToInt32(arr[1]);
                turnover3 = Convert.ToInt32(arr[0]);

            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Wrong input");
            }
            DiscountCard dc1 = new BronzeDiscountCard((float)turnover1,(float)purchase1);
            dc1.calculateDiscount();
            DiscountCard dc2 = new SilverDiscountCard((float)turnover2, (float)purchase2);
            dc2.calculateDiscount();
            DiscountCard dc3 = new GoldDiscountCard((float)turnover3, (float)purchase3);
            dc3.calculateDiscount();
            Console.WriteLine(dc1.ToString());
            Console.WriteLine(dc2.ToString());
            Console.WriteLine(dc3.ToString());
        }
    }
}
