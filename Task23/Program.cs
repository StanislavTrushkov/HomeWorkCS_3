// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

using System;
{
Console.Write("Введите число: ");
int NumCube = Convert.ToInt32(Console.ReadLine());

void cube(int[] NumCube)
{
    int counter = 0;
    int length = NumCube.Length;
    while (counter <  length)
    {
        NumCube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    while(index < count)
    {
        Console.Write(coll[index]+ " ");
        index++;
    }
} 

int[] array = new int[NumCube+1];
cube(array);
PrintArray(array);
Console.ReadKey();
}
