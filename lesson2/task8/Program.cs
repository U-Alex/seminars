//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

string step(int num) {
    string text = "";
    for (int x=2; x <= num; x+=2) {
        //Console.Write(x.ToString() + ", ");
        text += $"{x} ";
    }
    return text;
}
void print(string text, int num) {
    Console.WriteLine("целые числа от 1 до "+ num.ToString() +":");
    Console.WriteLine(text);
}
Console.WriteLine("введите целое число ");
int num = int.Parse(Console.ReadLine());
print(step(num), num);

