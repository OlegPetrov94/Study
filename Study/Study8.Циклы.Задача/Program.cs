//SimpleFor();

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

for (int i = 0; i <= (2 * age -1); i++)
{
    Console.WriteLine("*");
}
Console.WriteLine();

//int n = 10; // количество уровней елки
//for (int i = 1; i <= n; i++)
//{
//    // Отрисовываем отступы перед звездочками
//    for (int j = n - i; j > 0; j--)
//    {
//        Console.Write(" ");
//    }

//    // Отрисовываем звездочки
//    for (int k = 1; k <= (2 * i - 1); k++)
//    {
//        Console.Write("*");
//    }

//    // Переход на новую строку
//    Console.WriteLine();
//}
