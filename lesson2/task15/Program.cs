
bool check_day(int num) {
    return num == 6 | num == 7;
}

Console.Write("цифру, обозначающую день недели (1-7) ");
int number = int.Parse(Console.ReadLine());
if (number < 1 | number > 7) Console.WriteLine("не правильный ввод");
else {
    if (check_day(number)) Console.WriteLine("выходной день");
    else                   Console.WriteLine("рабочий день");
}
