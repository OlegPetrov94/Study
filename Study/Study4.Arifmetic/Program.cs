////Бинарные операции 
//Сложение двух чисел
using System.ComponentModel;

int x = 23;
int y = x + 1;//24
Console.WriteLine(y);

//Вычетание двух чисел
int z = 54;
int q = z - 45; // 9
Console.WriteLine(q);

//Умножение двух чисел
int r = 12;
int s = r * 3;//36
Console.WriteLine(s);

// Деления двух чисел
int t = 25;
int w = t / 3;//8
Console.WriteLine(w);
double e = 25;
double f = e / 3;//8,333333333333334
Console.WriteLine(f);

//Получение остатка от целочисленного деления 
int t1 = 25;
int w2 = t1 % 3;//1
Console.WriteLine(w2);

//// Унарные операции
// Операции инкремента (увеличение на ЕДИНИЦУ)
// Префиксный инкремент 
int x2 = 25;
//int y2 = ++x2;
x2 = 1 + x2;
int y2 = x2;
Console.WriteLine($"{x2}, {y2}");// 26. 26

// Постфиксный инкремент
int z2 = 25;
//int q2 = z2++;
int q2 = z2;
z2 = z2 + 1;
Console.WriteLine($" {z2}, {q2} ");//26. 25

//Операция декремента
//Префиксный декремент
int r2 = 25;
//int s2 = --r2;
r2 = r2 - 1;
int s2 = r2;
Console.WriteLine($" {r2}, {s2} ");// 24.24

//Постфиксный декремент
int t3 = 25;
//int w3 = t3--;
int w3 = t3;
t3 = t3 - 1;
Console.WriteLine($" {t3}, {w3} ");//24.25


