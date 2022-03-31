using System;
class MainClass
{
    public static void Main(string[] args)
    {
        string MyNameOne = "Jane";
        byte MyAge = 27;
        bool HaveIApet = true;
        double MyShoeSize = 37.5;

        Console.WriteLine("My name is " + MyNameOne);
        Console.WriteLine("MyAge " + MyAge);
        Console.WriteLine("Do I have a pet? " + HaveIApet);
        Console.WriteLine("My shoe size is " + MyShoeSize);

        string MyNameSecond = "Евгения";
        Console.WriteLine("Привет, Мир");
        Console.WriteLine();
        Console.WriteLine($"Меня зовут {MyNameSecond}");

        Console.ReadKey();
    }
}