// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray(ref int[,,] arr, int from, int to) {
    List<int> nums = new List<int>();
    Random rnd = new Random();
    int num;
    int rand() {
        do {
            num = rnd.Next(from, to);
        } while (nums.Contains(num));
        nums.Add(num);
        return num;
    }
    int iLen = arr.GetLength(0);
    int jLen = arr.GetLength(1);
    int kLen = arr.GetLength(2);
    for (int i = 0; i < iLen; i++) {
        for (int j = 0; j < jLen; j++) {
            for (int k = 0; k < kLen; k++) {
                arr[i, j, k] = rand();
                //вывод массива сделан в отдельном методе через рекурсию
                //Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void PrintArray(ref int[,,] arr, int i=0, int j=0, int k=0) {
    if (k == arr.GetLength(2)) { 
        ++j; 
        k = 0; 
        Console.WriteLine();
    }
    if (j == arr.GetLength(1)) { 
        ++i; 
        j = 0; 
        Console.WriteLine();
    }
    if (i == arr.GetLength(0)) return;
    Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
    PrintArray(ref arr, i, j, ++k);
    
}

int[,,] arr = new int[3,4,5];
int randFrom = 10;
int randTo = 100;

if (arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2) > (randTo - randFrom)) {
    Console.WriteLine("слишком большой размер массива для интервала уникальных чисел");
}
else {
    FillArray(ref arr, randFrom, randTo);
    PrintArray(ref arr);
}
