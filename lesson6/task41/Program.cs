// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

List<int> inputNum() {
    bool ok = false;
    List<int> nums = new List<int>();
    while (!ok) {
        Console.WriteLine("введите целые числа через запятую или через пробел, например 3,5 -4 100");
        string[] inp = Console.ReadLine().Replace(" ", ",").Trim(new Char[] {' ', ','}).Split(",");
        int len = inp.Length;
        if (len > 1) {
            int temp;
            nums.Clear();
            for (int i=0; i < len; i++) {
                if (int.TryParse(inp[i], out temp)) {
                    ok = true;
                    nums.Add(temp);
                }
                else {
                    ok = false;
                    Console.WriteLine("ошибка парсинга");
                    break;
                }
            }
        }
    }
    return nums;//(ok) ? nums : (-1);
}

int posNum(List<int> nums) {
    int cnt = 0;
    foreach (int num in nums) {
        if (num > 0) cnt++;
    }
    return cnt;
}

List<int> nums = inputNum();
int count = posNum(nums);

Console.WriteLine($"количество чисел больше 0: {count} из {nums.Count}");