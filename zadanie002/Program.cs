// По двум заданным числам проверять является ли одно квадратом другого

int[] num = new int[2];
string Result = "не является";

for (int i = 0; i < 2; i++)
{
    num[i] = new Random().Next(1, 100);
}

if (num[0] / num[1] == num[1]) Result = Result.Replace("не ", "");

System.Console.WriteLine($"Число {num[0]} {Result} квадратом числа {num[1]}");
System.Console.WriteLine();



//

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if (a == b * b)
{
	Console.WriteLine("a является квадратом b");
}
else if (b == a * a)
{
	Console.WriteLine("b является квадратом a");
}
else 
{
	Console.WriteLine("Одно не является квадратом другого");
}
