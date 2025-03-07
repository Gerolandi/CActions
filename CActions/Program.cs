Console.WriteLine("Calculating square");
Console.WriteLine("Give width");
double width = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Give height");
double height = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"The square are {width * height}");
