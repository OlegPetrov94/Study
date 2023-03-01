//Написать программу вычисления стоимости покупки с учотом скидки. Скидка в 5% предоставляется если сумма покупки больше 500руб. Скидка в 10% - если сумма покупки больше 1000р.

Console.WriteLine("С вас: ");
string ageS = Console.ReadLine();
int age = Convert.ToInt32(ageS);
if (age < 0)
{
    Console.WriteLine("Ошибка");
}
else if (age < 500)
{
    Console.WriteLine("Ваша скидка:");
    Console.WriteLine("У вас нет скидки.");
    Console.WriteLine("Сумма к оплате:");
    Console.WriteLine(age);
}
else if ((age > 500) & (age < 1001))
{
    Console.WriteLine(" Ваша скидка: ");
    Console.WriteLine((5 * age) / 100);
    Console.WriteLine("Сумма к оплате: ");
    Console.WriteLine(age - (5 * age) / 100);
}
else if (age > 1000) 
{
    Console.WriteLine(" Ваша скидка: ");
    Console.WriteLine((10 * age) / 100);
    Console.WriteLine("Сумма к оплате: ");
    Console.WriteLine(age - (10 * age) / 100); 
}