﻿/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
   длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
   либо задать на старте выполнения алгоритма. */

string Message(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

int limit = 4;
int size = Convert.ToInt32(Message($"Задайте размер массива строк: "));
string[] arrayOne = new string[size];


void FillArray(string[] arr)
{
    Random rand = new Random();
    string AllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    for (int i = 0; i < size; i++)
    {
        int elementSize = rand.Next(1, 9);
        for (int j = 0; j < elementSize; j++)
        {
            arr[i] += AllSymbols[rand.Next(0, AllSymbols.Length)];
        }
    }
}


FillArray(arrayOne);
Console.WriteLine();
