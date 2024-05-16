using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 0;

        while (true)
        {
            Console.Write("sisesta num (1, 2, or 3): ");
            string input = Console.ReadLine();

            num = int.Parse(input) == 1 ? 10 : int.Parse(input) == 2 ? 20 : int.Parse(input) == 3 ? 30 : 0;

            Console.WriteLine("tulemus on: " + num);

            Console.Write("tahad edaneda? (y/n): ");
            string response = Console.ReadLine();

            if (response.ToLower() != "y")
            {
                break;
            }
        }
    }
}