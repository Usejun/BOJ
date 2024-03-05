int n = int.Parse(Console.ReadLine());
var a = new long[120];
a[0] = a[1] = a[2] = 1;
for (int i = 3; i < 117; i++)
    a[i] = a[i - 1] + a[i - 3];
Console.Write(a[n-1]);