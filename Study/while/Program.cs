ObratniuOtschetWhile();

static void ElkaWhile()
{
    Console.WriteLine("Введите число: ");
    string number = Console.ReadLine();
    int number1 = Convert.ToInt32(number);
    string text = "";
    int i = 0;
    while (i <= number1)
    {
        //text += "*"; 
        text = text + "*";
        Console.WriteLine(text);
        i++;
    }
    Console.WriteLine();
}


static void ContinueBreakWhile()
{
    Console.WriteLine(" Введите число ");
    string resault = Console.ReadLine();
    int resault1 = Convert.ToInt32(resault);
    int i = 0;
    while (i < resault1)
    {
        i++;
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

static void ObratniuOtschetWhile()
{
    Console.WriteLine("Введите первое число ");
    string resault5 = Console.ReadLine();
    int resault6 = Convert.ToInt32(resault5);
    Console.WriteLine("Введите второе число ");
    string resault7 = Console.ReadLine();
    int resault3 = Convert.ToInt32(resault7);
    int i = resault6;
    if (resault3 > resault6)
    {
        Console.WriteLine("Ошибка");
    }
    else
    {
        while (i >= resault3)
        {
            Console.WriteLine(i);
            i--;
        }
    }
}