// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateArray(int a, int b) {
    int[,] array = new int[a, b];
    for (int i=0; i < b; i++) {
        for (int j=0; j < a; j++) {
            array[j, i] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(ref int[,] array) {
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    string separator = new System.Text.StringBuilder().Insert(0, "---", a).ToString();
    Console.WriteLine(separator);
    for (int i=0; i < b; i++) {
        for (int j=0; j < a; j++) {
            Console.Write($"{array[j, i]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(separator);
}
int InputNum() {
    int num = 0;
    bool ok = false;
    while (!ok) {
        Console.Write("введите целое число:  ");
        string inp = Console.ReadLine().Trim();//.Split(",");
            if (int.TryParse(inp, out num)) ok = true;
    }
    return num;
}
List<int[]> FindNum(ref int[,] array, int num) {
    List<int[]> res = new List<int[]>{};
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    for (int i=0; i < a; i++) {
        for (int j=0; j < b; j++) {
            if (array[i, j] == num) {
                res.Add(new int[2]{i, j});
            }
        }
    }

    return res;
}
void PrintPositions(ref List<int[]> result) {
    if (result.Count() == 0) { Console.WriteLine("такого числа в массиве нет"); }
    else {
        Console.Write("позиции числа: ");
        foreach (int[] pos in result) {
            Console.Write($"[{String.Join(",", pos)}] ");
        }
    }
}

int rows = 7;
int columns = 4;

int[,] array = CreateArray(rows, columns);
PrintArray(ref array);

List<int[]> result = FindNum(ref array, InputNum());
PrintPositions(ref result);
