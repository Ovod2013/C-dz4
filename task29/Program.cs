/*Задача 29: Напишите программу, которая задаёт
 массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]*/


int[] massiv = new int[8];
Random rnd = new Random();
//Console.WriteLine(rnd.Next(0, 99));

for (int i=0; i<8; i++)
{
    massiv[i] = rnd.Next(0, 100);
    if (i<7) {Console.Write(massiv[i] + ", ");}
    else Console.Write(massiv[i]);
}

