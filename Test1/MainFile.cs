using System;

class Example
{
    public static void Main()
    {
        Console.WriteLine("Привет! Начнем...");
        Console.Write("Введите значение a: ");
        string aStr = Console.ReadLine();
        Console.Write("Введите значение b: ");
        string bStr = Console.ReadLine();

        Console.WriteLine();

        try
        {
            int a = Convert.ToInt32(aStr);
            int b = Convert.ToInt32(bStr);
            if (a < b) 
                Console.WriteLine("a меньше b");
            else
                Console.WriteLine("b меньше a");
        }
        catch
        {
            Console.WriteLine("Введите правильное число!");
        }

        Console.WriteLine("Число\tКвадрат\tКуб");
        for (int i = 0; i <= 10; i++)
            Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
        Console.WriteLine("");
        Console.WriteLine("10 делим на 3 = {0:#.###}", 10.0 / 3.0);

        decimal Bal = 123.12m;
        Console.WriteLine("Баланс = {0:C}", Bal);
        Console.WriteLine("Тип переменной Баланс: {0}",Bal.GetType());

        Console.Read();
    }
}