//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool ch15(int num) {
    return num / 10000 == num % 10;
}
bool ch24(int num) {
    return num /1000 % 10 == num /10 % 10;
}

int num = 0;
bool ok = false;
while (!ok) {
    Console.Write("введите 5-значное число ");
    ok = int.TryParse(Console.ReadLine(), out num);
    if (ok && (num < 10000 || num > 99999)) ok = false;
}
if (ch15(num) && ch24(num)) {
    Console.WriteLine(num + " да");
}
else Console.WriteLine(num + " нет");
