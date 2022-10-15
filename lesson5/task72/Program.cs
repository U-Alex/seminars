// Написать программу возведения числа А в целую стень B

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
double myPow(int a, int b) {
    if (b > 0) {
        return myPow(a, b - 1) * a;
    }
    else return 1;
}

int[] nums = inputNum();
double result = myPow(nums[0], nums[1]);
Console.WriteLine($"число {nums[0]} в степени {nums[1]}: {result}");
