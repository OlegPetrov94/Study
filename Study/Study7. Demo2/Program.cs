OnlyIf();
InnerIfElse();
TernarOperation();

static void OnlyIf()
{
	Console.WriteLine("Введите сумму: ");
	string inputSum = Console.ReadLine();

	int sum = Convert.ToInt32(inputSum);

	string result = "";

	if (sum < 0)
	{
		result = "Ошибка";
	}

	if (sum >= 0 && sum <= 500)
	{
		result = $"Ваша скидка: у вас нет скидки. \nСумма к оплате: {sum}";
	}

	if ((sum > 500) & (sum < 1001))
	{
		decimal skidka = (5 * sum) / 100;
		decimal finishSuma = sum - (5 * sum) / 100;
		result = $"Ваша скидка: {skidka}. \nСумма к оплате: {finishSuma}";
	}

	if (sum > 1000)
	{
		decimal skidka = (10 * sum) / 100;
		decimal finishSuma = sum - (10 * sum) / 100;
		result = $"Ваша скидка: {skidka}. \nСумма к оплате: {finishSuma}";
	}

	Console.WriteLine(result);
}
static void InnerIfElse()
{
	Console.WriteLine("Введите сумму: ");
	string inputSum = Console.ReadLine();

	int sum = Convert.ToInt32(inputSum);

	string result = "";

	if (sum < 0)
	{
		result = "Ошибка";
	}
	else
	{
		if (sum >= 0 && sum <= 500)
		{
			result = $"Ваша скидка: у вас нет скидки. \nСумма к оплате: {sum}";
		}
		else
		{
			if ((sum > 500) & (sum < 1001))
			{
				decimal skidka = (5 * sum) / 100;
				decimal finishSuma = sum - (5 * sum) / 100;
				result = $"Ваша скидка: {skidka}. \nСумма к оплате: {finishSuma}";
			}
			else
			{
				decimal skidka = (10 * sum) / 100;
				decimal finishSuma = sum - (10 * sum) / 100;
				result = $"Ваша скидка: {skidka}. \nСумма к оплате: {finishSuma}";
			}
		}
	}

	Console.WriteLine(result);
}

static void TernarOperation()
{
	Console.WriteLine("Внимание. Введите число, а я вам скажу, четное оно или не четное!");
	string x = Console.ReadLine();
	int number = Convert.ToInt32(x);

	//string result = string.Empty;

	//if (number % 2 == 0)
	//{
	//	result = "Ваше число делится на 2 без остатка, следовательно оно четное!";
	//}
	//else
	//{
	//	result = "Ваше число не делится на 2 без остатка. Остаок равен 1. Следовательно оно нечетное!";
	//}

	string result = (number % 2 == 0) ? "Ваше число делится на 2 без остатка, следовательно оно четное!" : "Ваше число не делится на 2 без остатка. Остаок равен 1. Следовательно оно нечетное!";

	Console.WriteLine(result);
}