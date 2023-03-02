// Написать программу вычисления стоимости покупки с учотом скидки. Скидка в 5% предоставляется если сумма покупки больше 500руб. Скидка в 10% - если сумма покупки больше 1000р.

Console.WriteLine("Введите сумму: ");
string inputSum = Console.ReadLine();

int sum = Convert.ToInt32(inputSum);

string result = "";
//string result = string.Empty;

if (sum < 0)
{
	//Console.WriteLine("Ошибка");
	result = "Ошибка";
}
else if (sum < 500 - 1) //else if (sum <= 500)
{
	//Console.WriteLine("Ваша скидка:");
	//Console.WriteLine("У вас нет скидки.");
	//Console.WriteLine("Сумма к оплате:");
	//Console.WriteLine(sum);
	result = $"Ваша скидка: у вас нет скидки. \nСумма к оплате: {sum}";
}
else if ((sum > 500) & (sum < 1001))
{
	//Console.WriteLine(" Ваша скидка: ");
	//Console.WriteLine((5 * sum) / 100);
	//Console.WriteLine("Сумма к оплате: ");
	//Console.WriteLine(sum - (5 * sum) / 100);
	decimal skidka = (5 * sum) / 100;
	decimal finishSuma = sum - (5 * sum) / 100;
	result = $"Ваша скидка: {skidka}. \nСумма к оплате: {finishSuma}";
}
else if (sum > 1000)
{
	//	Console.WriteLine(" Ваша скидка: ");
	//	Console.WriteLine((10 * sum) / 100);
	//	Console.WriteLine("Сумма к оплате: ");
	//	Console.WriteLine(sum - (10 * sum) / 100);
	decimal skidka = (10 * sum) / 100;
	decimal finishSuma = sum - (10 * sum) / 100;
	result = $"Ваша скидка: {skidka}. \nСумма к оплате: {finishSuma}";
}

Console.WriteLine(result);