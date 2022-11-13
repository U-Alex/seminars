// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray(ref int[,,] arr, int num) {
    int iLen = arr.GetLength(0);
    int jLen = arr.GetLength(1);
    int kLen = arr.GetLength(2);
    for (int i = 0; i < iLen; i++) {
        for (int j = 0; j < jLen; j++) {
            for (int k = 0; k < kLen; k++) {
                arr[i, j, k] = num++;
            }
        }
    }
    int temp, iRand, jRand, kRand;
    Random rnd = new Random();
    for (int i = 0; i < iLen; i++) {
        for (int j = 0; j < jLen; j++) {
            for (int k = 0; k < kLen; k++) {
                iRand = rnd.Next(0, iLen);
                jRand = rnd.Next(0, jLen);
                kRand = rnd.Next(0, kLen);
                temp = arr[i, j, k];
                arr[i, j, k] = arr[iRand, jRand, kRand];
                arr[iRand, jRand, kRand] = temp;
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
    Console.Write($"{arr[i, j, k]}({i},{j},{k})\t");
    PrintArray(ref arr, i, j, ++k);
    
}

int[,,] arr = new int[4,5,6];
int randFrom = 10;

FillArray(ref arr, randFrom);
PrintArray(ref arr);

