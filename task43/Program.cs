Console.WriteLine("введите b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите k2");
int k2 = Convert.ToInt32(Console.ReadLine());

double[] FindXY(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}

void PrintXY(double[] array)
{
    Console.WriteLine($"X: {(double)array[0]}");
    Console.WriteLine($"Y: {(double)array[1]}");
}

double[] myArray = FindXY(b1, k1, b2, k2);
PrintXY(myArray);