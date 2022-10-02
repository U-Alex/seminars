//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1 = new Random().Next(-1000, 1000);
int num2 = new Random().Next(-1000, 1000);
int num3 = new Random().Next(-1000, 1000);
Console.WriteLine("приняты числа: " + num1 +" "+ num2 +" "+ num3);
int num_max = num1;

if (num2 > num_max) num_max = num2;
if (num3 > num_max) num_max = num3;

Console.WriteLine("максимальное " + num_max);
