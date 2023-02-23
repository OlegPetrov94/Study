// Создаем текстовую переменную name и сразу ее иницилизируем
string name = "Oleg";
// выводим значение переменной name на консоль
Console.WriteLine(name);
 
Console.WriteLine("введите свое имя");// ВВОДИМ ПРОСЬБУ 
string name1 = Console.ReadLine();// ИНИЦИЛИЗИРУЕМ ПЕРЕМЕННУЮ NAME1 С ПОМОЩЬЮ МЕТОДА РЕДЛАЙН
string resaut = "Привет " + name1;//СОЗДАЛИ НОВУЮ ПЕРЕМЕННУЮ И В НЕЙ ОБЪЕДЕНИЛИ ТЕКСТ И ПЕРЕМЕННУЮ НАМЕ1 (КОНКАТИНАЦИЯ)
Console.WriteLine(resaut);// ВЫВОДИМ РЕЗУЛЬТАТ ОБЪЕДИНЕНИЯ


Console.WriteLine("введите свою фамилию");
string surname = Console.ReadLine();
string resaut1 = $"твоя фамилия {surname}, а твое имя {name1}"; // это интерполяция
Console.WriteLine(resaut1);

// ctrl+D создать дублекат строчки
// alt вниз вверх перетаскивание строк
// ctrl+K,crtl+C ЗАКОММЕНТИРОВАТЬ 
// CTRL+K, CTRL+U РАСКОММЕНТИРОВАНИЕ
// CTRL+K CTRL+D ЭТО ВЫРАВНИВАНИЯ ТЕКСТА

