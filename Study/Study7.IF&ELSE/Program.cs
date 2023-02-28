//// Конструкция if...else
//Конструкция if/else проверяет истинность некоторого условия и в зависимости от результатов проверки выполняет определенный код.
// Конструкция "if" - если

//if (условия)
//{
//    выполняемые условия
//}

int num1 = 8;
int num2 = 6;
if ( num1 > num2 )
{
    Console.WriteLine( $"Число {num1} больше числа {num2}" );
}
//В данном случае у нас первое число больше второго, поэтому выражение num1 > num2 истинно и возвращает true, следовательно, управление переходит к строке Console.WriteLine("Число {num1} больше числа {num2}");


#region Так писать не стоит
//Если блок if содержит одну инструкцию, то мы можем его сократить, убрав фигурные скобки:
int num3 = 8;
int num4 = 6;
if (num1 > num2)
    Console.WriteLine($"Число {num3} больше числа {num4}");
//или так
if (num3 > num4) Console.WriteLine($"Число {num3} больше числа {num4}"); 
#endregion

//Выражение "else" - иначе
// Выполняется если не выполнилось никакое условие
int num5 = 8;
int num6 = 6;
if (num1 > num2)
{
    Console.WriteLine($"Число {num5} больше числа {num6}");
}
else
{
    Console.WriteLine($"Число {num5} меньше числа {num6}");
}
//Блок else выполняется, если условие после if ложно, то есть равно false.

// "else if"
//Но в примере выше при сравнении чисел мы можем насчитать три состояния: первое число больше второго, первое число меньше второго и числа равны. Используя конструкцию else if, мы можем обрабатывать дополнительные условия
int num7 = 8;
int num8 = 6;
if (num7 > num8)
{
    Console.WriteLine($"Число {num7} больше числа {num8}");
}
else if (num7 < num8)
{
    Console.WriteLine($"Число {num7} меньше числа {num8}");
}
else
{
    Console.WriteLine($"Число {num7} ровно числy {num8}");
}

//При необходимости можно добавить несколько выражений "else if"
string name = "Alex";

if (name == "Tom")
{
    Console.WriteLine("Вас зовут Tomas");
}
else if(name =="Bob")
{
    Console.WriteLine("Вас зовут Robert");
}
else if(name =="Mike")
{
    Console.WriteLine("Вас зовут Michel");
}
else
{
    Console.WriteLine("Неизвестное имя");
}