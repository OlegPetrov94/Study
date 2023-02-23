string hello = "Привет мир";
Console.WriteLine(hello);
Console.WriteLine("Добро пожаловать в C#!");
Console.WriteLine("Пока мир...");
Console.WriteLine(24.5);

Console.WriteLine("------------------------------");

string name = "Tom";
int age = 34;
double height = 1.7;
Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м"); //интерполяция
Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}m", name, height, age);

Console.WriteLine("------------------------------");

Console.Write("Введите свое имя: ");
string? name1 = Console.ReadLine();
Console.WriteLine($"Привет {name1}");