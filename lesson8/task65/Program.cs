//Спирально заполнить двумерный массив

void FillArray(ref int[,] mass, int body=1) {
    int iLen = mass.GetLength(0);
    int jLen = mass.GetLength(1);
    int[] currIdx = new int[] {0,0};
    int[] nextIdx = new int[] {0,0};
    int idx_rule = 0;
    int[][] rule = new int[][] {
        new int[] {1,0},
        new int[] {0,1},
        new int[] {-1,0},
        new int[] {0,-1}
    };
    for (int step = 0; step < iLen*jLen; step++) {
        mass[currIdx[0],currIdx[1]] = body++;
        nextIdx[0] = currIdx[0] + rule[idx_rule][0];
        nextIdx[1] = currIdx[1] + rule[idx_rule][1];
        if ((nextIdx[0] < 0) || (nextIdx[0] >= iLen) ||
            (nextIdx[1] < 0) || (nextIdx[1] >= jLen) ||
            (mass[nextIdx[0], nextIdx[1]] > 0)) {
                idx_rule = (idx_rule > 2) ? 0 : idx_rule+1 ;
                currIdx[0] += rule[idx_rule][0];
                currIdx[1] += rule[idx_rule][1];
        }
        else {
            currIdx[0] = nextIdx[0];
            currIdx[1] = nextIdx[1];
        }
    }
}
void PrintArray(ref int[,] mass) {
    int iLen = mass.GetLength(0);
    int jLen = mass.GetLength(1);
    Console.Clear();
    for (int j=0; j < jLen; j++) {
        for (int i=0; i < iLen; i++) {
            Console.Write($"{mass[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] mass = new int[5, 4];

FillArray(ref mass, 1);
PrintArray(ref mass);
