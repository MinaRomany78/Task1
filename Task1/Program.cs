using System.Diagnostics;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of small carpets:");
            int sNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets:");
            int lNum = Convert.ToInt32(Console.ReadLine());
            int Cost = sNum * 25 + lNum * 35;
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            Console.WriteLine($"Cost : ${Cost} ");
            double Tax = Convert.ToDouble(Cost )* 6 / 100;
            Console.WriteLine($"Tax : ${Tax} ");
            Console.WriteLine("================================");
            double Total =Convert.ToDouble( Tax + Cost);
            Console.WriteLine($"Total estimate : ${Total} ");
            Console.WriteLine("This estimate is valid for 30 days") ;




        }
    }
}
