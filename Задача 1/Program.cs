//Задача 19
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();

Console.Write("Введите число для проверки: ");
bool palindrome = true;
int x = int.Parse(Console.ReadLine());
int c = x.ToString().Length - 1;
string b = x.ToString();
for (int i = 0; i < c; i++)
    if (b[i] != b[c - i])
        palindrome = false;
if (palindrome == true)
    Console.Write("Да это число палиндром");
else
    Console.Write("Нет это число не палиндром");
