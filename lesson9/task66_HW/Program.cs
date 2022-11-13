// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int[] inputNum() {
    int[] num = new int[2];
    bool ok = false;
    while (!ok) {
        Console.WriteLine("введите 2 натуральных числа через '-' без пробелов, например 3-5 ");
        string[] inp = Console.ReadLine().Split("-");
        if (num.Length == 2) {
            if (int.TryParse(inp[0], out num[0]) &&
                int.TryParse(inp[1], out num[1])) {
                    if ((num[0] > 0) && (num[0] < num[1])) ok = true;
            }
        }
    }
    return num;
} 
int SumNums(int num_st, int num_end, int sum=0) {
    if (num_st < num_end) {
        sum += num_st;
        return SumNums(++num_st, num_end, sum);
    }
    return sum += num_st;
}

int[] nums = inputNum();
int result = SumNums(nums[0], nums[1]);
Console.WriteLine($"сумма элементов от {nums[0]} до {nums[1]}: {result}");
