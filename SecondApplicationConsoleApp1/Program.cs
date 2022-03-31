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

        string MyName = "Евгения";
        Console.WriteLine("Привет, мир");
        Console.WriteLine();
        Console.WriteLine("Меня зовут {0}", MyName);

        //0 — позиция нашей переменной. То есть переменная будет на позиции 0.

        //Также мы можем вставить в строку не переменную, а строковый литерал:
        Console.WriteLine("Меня зовут {0}", "Маша");

        //И, естественно, мы можем использовать несколько переменных при выводе. В этом случае располагаем их в порядке нумерации «мест».
        var age = 27;
        var weight = 50;
        Console.WriteLine("Возраст {0} \n Вес {1}", age, weight);

        string CompName = "Computer";
        Console.WriteLine("Привет, человек");
        Console.WriteLine("Меня зовут {0}", CompName);
        Console.Write("А как тебя зовут? ");
        string YourName = Console.ReadLine();
        Console.Write("Рад встрече, {0} ", YourName);

        Console.ReadKey();
    }
}