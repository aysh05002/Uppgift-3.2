using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Har du gått ut på gymnasiet ? j/n");
        string j_n = Console.ReadLine();

        Console.WriteLine("Hur gammal är du ?");
        int ålder = Convert.ToInt32(Console.ReadLine());

        if (j_n == "j" && ålder < 22 && ålder > 18)
        {
            Console.WriteLine("Vi vill gärna anställa dig.");
        }
        else
        {
            Console.WriteLine("Vi letar tyvär efter annan personal just nu.");
        }
    }
}