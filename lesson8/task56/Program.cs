// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateArray(int a, int b) {
    int[,] array = new int[a, b];
    for (int i=0; i < b; i++) {
        for (int j=0; j < a; j++) {
            array[j, i] = new Random().Next(0, 2);
        }
    }
    return array;
}
void PrintArray(ref int[,] array) {
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    string separator = new System.Text.StringBuilder().Insert(0, "--------", a).ToString();
    for (int i=0; i < b; i++) {
        for (int j=0; j < a; j++) {
            Console.Write($"{array[j, i]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine(separator);
}
int[] SumLineArray(ref int[,] array) {
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int[] line = new int[b];
    int sum;
    for (int i=0; i < b; i++) {
        sum = 0;
        for (int j=0; j < a; j++) {
            sum += array[j, i];
        }
        line[i] = sum;
    }
    return line;
}
List<int> FindMinElem(int[] sumLine) {
    List<int> minList = new List<int>();
    int min = sumLine[0];
    for (int i=1; i < sumLine.Length; i++) {
        if (min > sumLine[i]) min = sumLine[i];
    }
    for (int i=0; i < sumLine.Length; i++) {
        if (min == sumLine[i]) minList.Add(i+1);
    }
    return minList;
}

int rows = 7;
int columns = 5;
Console.Clear();
int[,] array = CreateArray(rows, columns);
PrintArray(ref array);
List<int> result = FindMinElem(SumLineArray(ref array));

Console.Write("строка (строки) с минимальной суммой элементов:  ");
Console.Write(String.Join(", ", result));
