//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string step(int num) {
    string text = "";
    for (int x=1; x <= num; x++) {
        text += $"{x*x*x} ";
    }
    return text;
}
void print(string text, int num) {
    Console.WriteLine("кубы числа от 1 до "+ num.ToString() +":");
    Console.WriteLine(text);
}

int num = 0;
bool ok = false;
while (!ok) {
    Console.Write("введите целое число от 1 до 1000 ");
    ok = int.TryParse(Console.ReadLine(), out num);
    if (ok && (num < 1 || num > 1000)) ok = false;
}
print(step(num), num);
