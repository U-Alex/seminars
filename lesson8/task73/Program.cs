// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

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
int AddNums(ref List<int> listNum, int num1, int num2, int count) {
    if (count == 0) return 0;
    listNum.Add(num1+num2);
    return AddNums(ref listNum, num2, num1+num2, --count);
}

int count = 20;
int[] userNums = inputNum();
List<int> listNum = new List<int>();
listNum.Add(userNums[0]);
listNum.Add(userNums[1]);
int res = AddNums(ref listNum, userNums[0], userNums[1], count);

Console.WriteLine($"{String.Join(" ", listNum)} ({count} циклов)");
