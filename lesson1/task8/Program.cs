//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("введите целое число ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("целые числа от 1 до "+ num.ToString() +":");
for (int x=2; x <= num; x+=2) {
    Console.Write(x.ToString() + ", ");
}
