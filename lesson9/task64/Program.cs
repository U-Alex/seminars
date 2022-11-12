
int[,] CreateTriangle(int row) {
    int[,] tri = new int[row, row];
    for (int i = 0; i < row; i++) {
        tri[i, 0] = 1;
        tri[i, i] = 1;
    }
    for (int i = 2; i < row; i++) {
        for (int j = 1; j < i; j++) {
            tri[i, j] = tri[i-1, j-1] + tri[i-1, j];
        }
    }
    return tri;
}
void PrintTriangle(int[,] tri) {
    int row = tri.GetLength(0);
    int width = 1;
    int col = row * width;
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < row; j++) {
            Console.SetCursorPosition(col, i+1);
            if (tri[i, j] % 2 != 0) Console.Write("0");
            col += width * 2;
        }
        col = row * width - width * (i + 1);
        Console.WriteLine();
    }
}

int[,] triangle = CreateTriangle(16);
PrintTriangle(triangle);
