//Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

int sum_num(int num) {
    int sum = 0, num2 = 0;
    while (num >= 10) {
        num2 = num % 10;
        num /= 10;
        sum += num2;
    }
    return sum + num;
}

int num = new Random().Next(100, 10000);
int sum = sum_num(num);
Console.WriteLine($"сумма цифр в числе {num} - {sum} ");
