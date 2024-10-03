var f = () => int.Parse(Console.ReadLine());
int a = f(), b = f(), c = f();
Console.WriteLine(a + b - c);
Console.WriteLine(a * Math.Pow(10, (int)Math.Log10(b) + 1) + b - c);
