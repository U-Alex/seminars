
int[] data = new int[]{0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = new int[]{2, 3, 3, 1 };

List<int> BuildNum(ref int[] data, ref int[] info) {
    int dataLen = data.Length;
    int ind = 0;
    int num;
    List<int> dataNum = new List<int>();
    List<int> result = new List<int>();
    foreach (int cnt in info) {
        if (ind + cnt > dataLen) {
            result.Add(-1);
            break;
        }
        dataNum.Clear();
        for (int iter = 0; iter < cnt; iter++) {
            dataNum.Add(data[ind+iter]);
        }
        num = 0;
        dataNum.Reverse();
        for (int i = 0; i < dataNum.Count(); i++) {
            num += dataNum[i] * (int)Math.Pow(2, i);
        }
        result.Add(num);
        ind += cnt;
    }
    if (ind < dataLen) result.Add(-2);
    return result;
}
void PrintResult(ref List<int> result) {
    foreach (int num in result) {
        if (num >= 0) Console.Write($"{num} ");
        else {
            if (num == -1) Console.Write(" [выход за предел массива] ");
            if (num == -2) Console.Write(" [пройден не весь массив] ");
        }
    }
}

List<int> result = BuildNum(ref data, ref info);
PrintResult(ref result);


