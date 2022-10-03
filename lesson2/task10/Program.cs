
int second_digit(int num) {
    return num / 10 % 10;
}

int num = new Random().Next(100, 1000);
Console.WriteLine("случайное число - " + num);
int s_digit = second_digit(num);
Console.WriteLine("вторая цифра - " + s_digit);