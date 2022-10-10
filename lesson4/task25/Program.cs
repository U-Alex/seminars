// опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.

int[] inputNum() {
    int a = 0, b = 0;
    bool ok = false;
    while (!ok) {
        Console.WriteLine("введите 2 числа через запятую без пробелов, например 3,5 ");
        string[] num = Console.ReadLine().Split(",");
        if (num.Length == 2) {
            if (int.TryParse(num[0], out a) &&
                int.TryParse(num[1], out b)) {
                    if (b > 0) {
                        ok = true;
                    }
                }
        }
    }
    return new int[2]{a, b};
} 
int myPow(int a, int b) {
    int result = a;
    for (int i = 1; i < b; i++) {
        result *= a;
    }
    return result;
}

int[] nums = inputNum();
int result = myPow(nums[0], nums[1]);
Console.WriteLine($"число {nums[0]} в степени {nums[1]}: {result}");
