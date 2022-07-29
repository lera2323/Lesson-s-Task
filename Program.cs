// задача 40. Напишите программу которая принимает на вход три числа и проверяет может ли существовать треугольник со сторонами такой длины

using System;

namespace ConsolApp
{
    class Program
    {
        static void Main (string[]args)
        {
int side_one = 5;
int side_two = 4;
int side_three = 3;

Check(side_one, side_two, side_three);
void Check(int side_one, int side_two, int side_three)

{
if (side_one + side_two > side_three && side_one + side_three > side_two && side_three + side_two > side_one)
{
    Console.WriteLine ("Заданные числа соответствуют сторонам треугольника");
}
else
{
    Console.WriteLine ("Задан не треугольник");
}
}

//Задача 42. Напишите программу которая переводит десятичное число в двоичное

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Zadacha42(number);
void Zadacha42(int currentNumber)
{
  string result = "";
  int startNumber = currentNumber;
  while (currentNumber > 0)
  {
     result = currentNumber % 2 + result;
     currentNumber/= 2;
  }
  Console.WriteLine ($"{startNumber} -> {result}");
}

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

Console.WriteLine("Введите число");
int first_number = 0;
int second_number = 1;
int finish_number = 80;

Console.WriteLine ("1.0");
Console.WriteLine ("2.1");

for (int i = 3; i <= finish_number; i++)
{
    int next_number = first_number + second_number;
    Console.WriteLine($"{i}. {next_number}");
    first_number = second_number;
    second_number = next_number;
}

// Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

int[] A = new int[8] {5, 8, 9, 10, -5, 0, -3, 1};
int[] B = new int [A.Length];

for (int i = 0; i < A.Length; i++)
{
    B[i] = A[i];
}

for (int i = 0; i < A.Length; i++)
{
    Console.Write (B[i] + "\t");
}

        }
        }
        }