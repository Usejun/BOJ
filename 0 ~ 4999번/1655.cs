using StreamWriter w = new(Console.OpenStandardOutput());
var f = () => int.Parse(Console.ReadLine());
int n = f(), k, i, s; 
List<int> l = new();

while (n-- > 0) 
{ 
    k = f(); 
    i = l.BinarySearch(k); 
    l.Insert(i < 0 ? ~i : i, k); 
    s = l.Count; 
    w.WriteLine(l[s / 2 - (1 - s % 2)]); 
}
