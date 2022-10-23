// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//  a1 b1   |   c1 d1       =   a1c1 + b1c2     a1d1 + b1d2
//  a2 b2   |   c2 d2       =   a2c1 + b2c2     a2d1 + b2d2
/*
int[,] array1 = {{2,1,3},
                 {4,3,2},
                 {1,1,4}};

int[,] array2 = {{3,2},
                 {2,3},
                 {3,2}};
*/
int[,] array1 = {{2,4}, 
                {3,2}};

int[,] array2 = {{3,4}, 
                {3,3}};

int[,] MultiMatrix(ref int[,] ar1, ref int[,] ar2) {
    int row = ar2.GetLength(0);
    int col = ar2.GetLength(1);
    int[,] ar3 = new int[row, col];
    for (int i=0; i < col; i++) {
        for (int j=0; j < row; j++) {
            for (int k=0; k < row; k++) {
                ar3[j, i] += ar1[j, k] * ar2[k, i];
            }
        }
    }
    return ar3;
}
void PrintArray(ref int[,] array) {
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i=0; i < row; i++) {
        for (int j=0; j < col; j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array3 = MultiMatrix(ref array1, ref array2);
PrintArray(ref array3);
