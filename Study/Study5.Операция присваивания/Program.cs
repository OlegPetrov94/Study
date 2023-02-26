// Присваивание после сложения   +=    A += B  эквивалентно А = А + В    
int a = 10;
//a += 10;
a = a + 10;
Console.WriteLine(a); //20

string name = "Oleg";
name = name + " Petrov";
name += " Eduardovich";
name += " Плохо разбирается";
Console.WriteLine(name);

// Присваивание после сложения   -=    A -= B  эквивалентно А = А - В    
//a -= 4;
a = a - 4;
Console.WriteLine(a);//16

// Присваивание после умножения   *=    А *= В  эквивалентно А = А * В
//a *= 2;
a = a * 2;
Console.WriteLine(a);//32

string name1 = "Oleg";
name1 += " petrov";

// Присваивание после деления    /=     А /= В  эквивалентно А = А / В
//а /= 8
a = a / 8;
Console.WriteLine(a);//4

// Присваивание после деления по модулю    %=    А %= В  эквивалентно А = А % В
//b %= 7
int b = 25;
b = b % 7;
Console.WriteLine(b);//4
