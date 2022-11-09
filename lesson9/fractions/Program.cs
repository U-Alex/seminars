
int[] ReductionFr(int[] fr) {
    if (fr[0] != 0) fr = SelectFr(fr);
    int min = (fr[1] < fr[2]) ? fr[1] : fr[2];
    for (int i = min; i > 1; i--) {
        if ((fr[1] % i == 0) && (fr[2] % i == 0)) {
            fr[1] /= i;
            fr[2] /= i;
            break;
        }
    }
    return fr;
}
int[] SelectFr(int[] fr) {
    if (fr[0] != 0) {
        return SumFr(new int[]{0, fr[0], 1}, 
                     new int[]{0, fr[1], fr[2]}
                     );
    }
    if (fr[1] > fr[2]) {
        fr[0] = fr[1] / fr[2];
        fr[1] = fr[1] % fr[2];
    }
    return fr;
}
int[] SumFr(int[] fr1, int[] fr2) {
    if (fr1[0] != 0) fr1 = SelectFr(fr1);
    if (fr2[0] != 0) fr2 = SelectFr(fr2);
    int[] res = new int[]{0, 0, 0};
    res[2] = fr1[2] * fr2[2];
    res[1] = fr1[1] * (res[2] / fr1[2]) + fr2[1] * (res[2] / fr2[2]);
    return ReductionFr(res);
}

int[] fr1 = new int[]{0, 14, 21};
int[] fr2 = new int[]{5, 1, 3};
int[] fr3 = new int[]{0, 22, 11};
int[] fr4 = new int[]{1, 5, 10};
int[] res = new int[3];

res = ReductionFr(fr1);
Console.WriteLine("{0, 14, 21} = " + String.Join(" ", res));

res = ReductionFr(fr2);
Console.WriteLine("{5, 1, 3} = " + String.Join(" ", res));

res = ReductionFr(fr3);
Console.WriteLine("{0, 22, 11} = " + String.Join(" ", res));

res = ReductionFr(fr4);
Console.WriteLine("{1, 5, 10} = " + String.Join(" ", res));

res = SelectFr(fr2);
Console.WriteLine("{5, 1, 3} = " + String.Join(" ", res) + " = " + String.Join(" ", SelectFr(res)));

res = SumFr(fr1, fr4);
Console.WriteLine("{0, 14, 21} + {1, 5, 10} = " + String.Join(" ", res) + " = " + String.Join(" ", SelectFr(res)));