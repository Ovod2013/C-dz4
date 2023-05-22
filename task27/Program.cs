/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int Vvod(string zapros)
{
    Console.Write(zapros);
    string value=Console.ReadLine()!;
    int result=Convert.ToInt32(value);
    return result;
}

int a = Vvod("Введите целое положительное число A: ");
Console.WriteLine("Вы ввели число: " + a );
int summa=SumCifr(a);
Console.WriteLine("Сумма всех цифр: " + summa );

int SumCifr(int x)
{
    int sumCifr=0; int i=0; int ch=x; int ost=0;
    for ( i=0; ch >= 1; i++)
    {
        ost=ch%10;
        sumCifr=sumCifr+ost;
        ch=ch/10;
    }
    return sumCifr;
}