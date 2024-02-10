int n = int.Parse(Console.ReadLine());
var s = Console.ReadLine();
Console.Write((s.Length - s.Replace("pPAp", "").Length) / 4);