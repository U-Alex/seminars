// Показать натуральные числа от 1 до N, N задано
// Найти сумму элементов от M до N, N и M заданы

int[] inputNum() {
    int[] num = new int[2];
    bool ok = false;
    while (!ok) {
        Console.WriteLine("введите 2 натуральных числа через '-' без пробелов, например 3-5 ");
        string[] inp = Console.ReadLine().Split("-");
        if (num.Length == 2) {
            if (int.TryParse(inp[0], out num[0]) &&
                int.TryParse(inp[1], out num[1])) {
                    if (num[0] > 0 && 
                        //num[1] > 0 && 
                        num[0] < num[1]) { ok = true; }
            }
        }
    }
    return num;
} 

string ForwNum(int num_st, int num_end, string res="") {
    if (num_st < num_end) {
        res += num_st.ToString() + ",";
        return ForwNum(++num_st, num_end, res);
    }
    return res += num_st.ToString();
}
/*
List<int> ForwNum2(int num_st, int num_end, ref List<int> res) {
    if (num_st < num_end) {
        res.Add(num_st);
        return ForwNum2(++num_st, num_end, ref res);
    }
    res.Add(num_st);
    return res;
}
*/
int ForwNum3(int num_st, int num_end, int sum=0) {
    if (num_st < num_end) {
        sum += num_st;
        return ForwNum3(++num_st, num_end, sum);
    }
    return sum += num_st;
}

int[] nums = inputNum();

string result = ForwNum(nums[0], nums[1]);
Console.WriteLine($"натуральные числа от {nums[0]} до {nums[1]}: {result}");


//List<int> result22 = new List<int>();
//List<int> result2 = ForwNum2(nums[0], nums[1], ref result22);
//Console.WriteLine($"натуральные числа от {nums[0]} до {nums[1]}: {String.Join(",", result2)}");

int result3 = ForwNum3(nums[0], nums[1]);
Console.WriteLine($"сумма элементов от {nums[0]} до {nums[1]}: {result3}");
