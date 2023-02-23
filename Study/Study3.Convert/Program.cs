Console.WriteLine("Введите имя: ");
string? name = Console.ReadLine();

Console.WriteLine("Введите возраст: ");
//int age = Convert.ToInt32(Console.ReadLine()); 
string ageS = Console.ReadLine();
int age = Convert.ToInt32(ageS);

Console.WriteLine("Введите рост: ");
//double height = Convert.ToDouble(Console.ReadLine());
string heightS = Console.ReadLine();
double height = Convert.ToDouble(heightS);

Console.WriteLine("Введите размер зарплаты: ");
//decimal salary = Convert.ToDecimal(Console.ReadLine());
string salaryS = Console.ReadLine();
decimal salary = Convert.ToDecimal(salaryS);

Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}m Зарплата: {salary}$");
