// Составить частотный словарь элементов массива для текстовых данных

string str = "Частотный анализ – это один из методов криптоанализа, основывающийся на предположении" +
            " о существовании нетривиального статистического распределения отдельных символов и их последовательностей" +
            " как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов" +
            " будет сохраняться в процессе шифрования и дешифрования.";

Dictionary<char, int> calculate(string str) {
    Dictionary<char, int> dict = new Dictionary<char, int>{};
    foreach (char simv in str) {
        if (dict.ContainsKey(simv)) dict[simv]++;
        else                        dict[simv] = 1;
    }
    return dict;
}
void printResult(Dictionary<char, int> dict, int len) {
    double freq;
    foreach (var simv in dict.OrderBy(simv => -simv.Value)) {
        freq = Math.Round((double)simv.Value / len * 100, 2);
        Console.WriteLine($"Символ '{simv.Key}' встречается {simv.Value} раз(а). Частота {freq} %");
    }
}

printResult(calculate(str), str.Length);
