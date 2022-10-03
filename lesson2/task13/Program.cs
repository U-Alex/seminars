
int check_3_digit(int num) {
    while (num > 999) num /= 10;
    return num % 10;
}
Console.Write("введите целое число ");
int number = int.Parse(Console.ReadLine());
if (number < 100) Console.WriteLine("третьей цифры нет");
else {
    int num = check_3_digit(number);
    Console.WriteLine(num);
}
