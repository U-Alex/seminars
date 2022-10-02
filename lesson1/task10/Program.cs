
int num = new Random().Next(100, 1000);
Console.WriteLine("случайное число - " + num);
num /= 10;
num %= 10;
Console.WriteLine("вторая цифра - " + num);