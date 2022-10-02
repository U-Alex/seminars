//Программа проверяет пятизначное число на палиндромом.

int num = new Random().Next(10000, 100000);
//int num = 12321;

bool ch15(int num) {
    return num / 10000 == num % 10;
}
bool ch24(int num) {
    return num /1000 % 10 == num /10 % 10;
}

if (ch15(num) & ch24(num)) {
    Console.WriteLine(num + " это полиндром");
}
else Console.WriteLine(num + " это НЕ полиндром");
