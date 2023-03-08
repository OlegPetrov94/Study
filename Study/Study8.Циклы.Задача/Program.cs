ObratniuOtschet();

static void Elka()
{
    // написать цикл 
    //Console.WriteLine("*");
    //Console.WriteLine("**");
    //Console.WriteLine("***");
    //Console.WriteLine("****");
    //Console.WriteLine("*****");

    //using System.Globalization;

    Console.WriteLine("Введите число: ");
    string ageS = Console.ReadLine();
    int age = Convert.ToInt32(ageS);
    string text = "";
    for (int i = 0; i <= age; i++)
    {
        //text += "*"; 
        text = text + "*";
        Console.WriteLine(text);
    }
    Console.WriteLine();
}

static void ForContinueBreak()
{
    //Написать программу которая спрашивает сколько раз нужно пройтись по циклу если число делиться на 3 без остатка, то мы не выводим это число на экран, если число = 16 то цикл дальше не выполняется 
    Console.WriteLine(" Введите число ");
    string resault = Console.ReadLine();
    int resault1 = Convert.ToInt32(resault);
    for (int i = 1; i < resault1; i++)
    {
        if (i == 16)
        {
            break;
        }

        if (i % 3 == 0)
        {
            continue;
        }

        Console.WriteLine(i);
    }
}

static void ObratniuOtschet()
{
    //Программа спрашивает два числа где первое число больше второго числа, если второе число больше первого числа программа сообщает что ошибка. 
    //если ввод корректен то необходимо отобразить все цифры от первого числа до второго чила в порядке уменьшения

    Console.WriteLine("Введите первое число ");
    string resault = Console.ReadLine();
    int resault1 = Convert.ToInt32(resault);
    Console.WriteLine("Введите второе число ");
    string resault2 = Console.ReadLine();
    int resault3 = Convert.ToInt32(resault2);

    if (resault3 > resault1)
    {
        Console.WriteLine("Ошибка");
    }
    else
    {
        for (int i = resault1; i >= resault3; i--)
        {
            Console.WriteLine(i);
        }
    }
}