// Показать натуральные числа от 1 до N, N задано
// Показать натуральные числа от N до 1, N задано

int inputNum() {
    int num = 0;
    bool ok = false;
    while (!ok) {
        Console.Write("введите целое число:  ");
        ok = int.TryParse(Console.ReadLine(), out num);
        if (ok && (num <= 0)) ok = false;
    }
    return num;
}

string incNum(int num_st, int num_end, string res="") {
    if (num_st < num_end) {
        res += num_st.ToString() + ",";
        return incNum(++num_st, num_end, res);
    }
    return res += num_st.ToString();;
}

string decNum(int num, string res="") {
    if (num > 1) {
        res += num.ToString() + ",";
        return decNum(--num, res);
    }
    return res += num.ToString();;
}

int num = inputNum();
string result = incNum(1, num);
Console.WriteLine($"натуральные числа от 1 до {num}: {result}");

string result2 = decNum(num);
Console.WriteLine($"натуральные числа от {num} до 1: {result2}");