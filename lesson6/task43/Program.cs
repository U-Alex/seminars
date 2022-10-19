// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] inputNum() {
    double[] nums = new double[4];
    bool ok = false;
    while (!ok) {
        Console.WriteLine("введите значения b1,k1,b2,k2 через запятую без пробелов для уравнения: y = k1 * x + b1, y = k2 * x + b2  ");
        string[] inp = Console.ReadLine().Trim().Split(",");
        if (inp.Length == 4) {
            if (double.TryParse(inp[0], out nums[0]) &&
                double.TryParse(inp[1], out nums[1]) &&
                double.TryParse(inp[2], out nums[2]) &&
                double.TryParse(inp[3], out nums[3])) ok = true;
        }
    }
    return nums;
}
double[] findPoint(double[] arg) {
    double x = Math.Round((arg[2] - arg[0]) / (arg[1] - arg[3]), 2);
    double y = Math.Round((arg[1] * (arg[2] - arg[0])) / (arg[1] - arg[3]) + arg[0], 2);
    return new double[2] {x, y};
}
//start
double[] arg = inputNum();
if ((arg[0] == arg[2]) && (arg[1] == arg[3])) Console.WriteLine("Прямые совпадают");
else{
    if (arg[1] == arg[3]) Console.WriteLine("Прямые параллельны");
    else {
        double[] result = findPoint(arg);
        Console.WriteLine($"({result[0]};{result[1]})");
    }
}



