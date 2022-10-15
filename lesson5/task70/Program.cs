// Найти сумму цифр числа

int inputNum() {
    int num = 0;
    bool ok = false;
    while (!ok) {
        Console.Write("введите целое число больше 9:  ");
        ok = int.TryParse(Console.ReadLine(), out num);
        if (ok && (num < 10)) ok = false;
    }
    return num;
}
int mySum(int num) {
    if (num >= 10) {
        return mySum(num / 10) + num % 10;
    }
    else return num;
}

int num = inputNum();
int result = mySum(num);
Console.WriteLine($"Сумму цифр числа {num}: {result}");
