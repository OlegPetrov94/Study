//SimpleFor();

// написать цикл 
//Console.WriteLine("*");
//Console.WriteLine("**");
//Console.WriteLine("***");
//Console.WriteLine("****");
//Console.WriteLine("*****");



static void SimpleFor()
{
    // сколько раз вывести приветствие


    Console.WriteLine("Введите число: ");
    string ageS = Console.ReadLine();
    int age = Convert.ToInt32(ageS);

    for (int i = 0; i < age; i++)
    {
        Console.WriteLine("Привет!");

    }
}

