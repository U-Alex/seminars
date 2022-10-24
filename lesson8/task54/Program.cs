// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
    for (int i=0; i < b; i++) {
        for (int j=0; j < a; j++) {
            Console.Write($"{array[j, i]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(separator);
}
void SortArray(ref int[,] array) {
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int[] line = new int[a];
    for (int i=0; i < b; i++) {
        for (int j=0; j < a; j++) line[j] = array[j, i];
        Array.Sort(line);
        Array.Reverse(line);
        for (int j=0; j < a; j++) array[j, i] = line[j] ;
    }
}

int rows = 7;
int columns = 4;
Console.Clear();
int[,] array = CreateArray(rows, columns);
PrintArray(ref array);
SortArray(ref array);
PrintArray(ref array);