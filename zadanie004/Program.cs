// Найти расстояние между точками в пространстве 2D/3D

int numPlans = 3;            
int min = -21;               
int max = 21;                

int[] PointCoord(int numPlans)                  
{
    int[] coords = new int[numPlans];
    for (int i = 0; i < numPlans; i++)
    {
        coords[i] = new Random().Next(min, max);
    }
    return coords;
}

void PrintCoord(int[] array)
{
    Console.Write($"({array[0]}, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]})");
}

double Distance(int[] arr1, int[] arr2)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum = sum + (arr1[i] - arr2[i]) * (arr1[i] - arr2[i]);
    }
    double result = Math.Sqrt(sum);
    return result;
}

int[] PointX = PointCoord(numPlans);
int[] PointY = PointCoord(numPlans);

Console.Write($"Координаты точки X: ");
PrintCoord(PointX);
Console.Write($"Координаты точки Y: ");
PrintCoord(PointY);

Console.WriteLine($"Расстояние между точками X и Y: {Distance(PointX, PointY)}");
Console.WriteLine();
