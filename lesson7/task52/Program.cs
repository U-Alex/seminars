// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArr(int a, int b) {
    int[,] array = new int[a, b];
    for (int i=0; i < b; i++) {
        for (int j=0; j < a; j++) {
            array[j, i] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArr(ref int[,] array) {
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    for (int i=0; i < b; i++) {
        for (int j=0; j < a; j++) {
            Console.Write($"{array[j, i]}\t");
        }
        Console.WriteLine();
    }
}
double[] Average(ref int[,] array, int round) {
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    double[] array2 = new double[a];
    double sum;
    for (int i=0; i < a; i++) {
        sum = 0;
        for (int j=0; j < b; j++) {
            sum += array[i, j];
        }
        array2[i] = (double)Math.Round(sum / array.GetLength(1), round);
    }
    return array2;
}

int rows = 7;
int columns = 4;
int round = 1;

int[,] array = CreateArr(rows, columns);
PrintArr(ref array);
double[] sums = Average(ref array, round);

Console.WriteLine(new System.Text.StringBuilder().Insert(0, "--------", rows).ToString());
Console.Write($"{string.Join("\t", sums)}");

