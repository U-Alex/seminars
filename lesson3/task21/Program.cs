//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double hypotenuse(double abx, double aby) {
    return Math.Sqrt((double)Math.Pow(abx, 2) + (double)Math.Pow(aby, 2));
}

List<int> inputCoord(string point) {
    int x = 0, y = 0, z = 0;
    bool ok = false;
    while (!ok) {
        Console.WriteLine($"введите координаты точки {point} через запятую без пробелов, например 1,-3,6 ");
        string[] coord = Console.ReadLine().Split(",");
        if (coord.Length == 3) {
            if (int.TryParse(coord[0], out x) &&
                int.TryParse(coord[1], out y) &&
                int.TryParse(coord[2], out z)) {
                    ok = true;
                }
        }
    }
    return new List<int>() {x, y, z};
} 
List<int> pointA = inputCoord("A");
List<int> pointB = inputCoord("B");
double result = hypotenuse(pointA[0]-pointB[0], hypotenuse(pointA[1]-pointB[1], pointA[2]-pointB[2]));

Console.WriteLine("расстояние между точками: " + Math.Round(result, 2).ToString());
