// Показать натуральные числа от 1 до N, N задано

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

string addNum(int num_st, int num_end, string res="") {
    if (num_st < num_end) {
        res += num_st.ToString() + ",";
        return addNum(++num_st, num_end, res);
    }
    return res += num_st.ToString();;
}

int num = inputNum();
string result = addNum(1, num);
Console.WriteLine($"натуральные числа от 1 до {num}: {result}");
