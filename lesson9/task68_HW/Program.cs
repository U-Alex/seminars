// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int[] inputNum() {
    int a = 0, b = 0;
    bool ok = false;
    while (!ok) {
        Console.WriteLine("введите 2 числа через запятую без пробелов, например 3,5 ");
        string[] num = Console.ReadLine().Split(",");
        if (num.Length == 2) {
            if (int.TryParse(num[0], out a) &&
                int.TryParse(num[1], out b)) {
                    if (a >= 0 && b >= 0) ok = true;
            }
        }
    }
    return new int[2]{a, b};
}

int Akkr(int n, int m) {
    if (n == 0) return ++m;
    if (m == 0) return Akkr(--n, 1);
    return Akkr(n-1, Akkr(n, --m));
}

int[] nums = inputNum();

Console.WriteLine($"A({nums[0]},{nums[1]}) = {Akkr(nums[0],nums[1])}");


