// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int NumberDay = new Random().Next(1, 8);
string[] Day = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
string txtResult = "";

if (NumberDay > 5) txtResult = $", Выходной!!!";
else txtResult = $", Рабочий день.";

Console.WriteLine();
Console.WriteLine($"{NumberDay} день недели - Это {Day [NumberDay - 1]}{txtResult}");
Console.WriteLine();


