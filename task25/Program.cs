﻿/* Задача 25: Напишите цикл, 
который принимает на вход 
два числа (A и B) и возводит 
число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Vvod(string zapros)
{
    Console.Write(zapros);
    string value=Console.ReadLine()!;
    int result=Convert.ToInt32(value);
    return result;
}

int a = Vvod("Введите первое целое число A: ");
int b = Vvod("Введите второе целое положительное число B: ");
Console.WriteLine("Введённые числа: " + a +" и " + b);

int a_step_b = Stepen(a,b);
Console.WriteLine("Степень А^B равна " + a_step_b);

int Stepen(int x, int y)
{
    int res;
    if (y==0) res=1;
    else res=x;
    for ( int i=1; i < y; i++)
    {
        res=res*x;
    }
    return res;
}
