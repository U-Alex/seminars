//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("введите первое число ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("введите второе число ");
double num2 = double.Parse(Console.ReadLine());

string result = "числа равны";
if (num1 != num2) {
    if (num1 > num2) result = num1 + " больше " + num2;
    else             result = num1 + " меньше " + num2; 
} 
Console.WriteLine(result);