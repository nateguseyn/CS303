using System;

class Program
{
    static void Main()
    {
        Console.Write("Zəhmət olmasa, yoxlanılacaq ədədi daxil edin: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine(number + " sadə ədəddir.");
        }
        else if (number == 1)
        {
            Console.WriteLine("1 nə sadə nə də mürəkkəb ədəddir.");
        }
        else
        {
            Console.WriteLine(number + " mürəkkəb ədəddir.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
