// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] createArr(int a, int b) {
    int[,] array = new int[a, b];
    for (int i=0; i < array.GetLength(1); i++) {
        for (int j=0; j < array.GetLength(0); j++) {
            array[j, i] = new Random().Next(0, 10);
        }
    }
    return array;
}
// int inputNum() {
//     int a = 0;
//     bool ok = false;
//     while (!ok) {
//         Console.WriteLine("введите число ");
//         string num = Console.ReadLine();
//             if (int.TryParse(num[0], out a) &&
//                 int.TryParse(num[1], out b)) {
//                     if (b > 0) {
//                         ok = true;
//                     }
//                 }
    
//     }
//     return new int[2]{a, b};
// } 

