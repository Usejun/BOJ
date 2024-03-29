using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int t = int.Parse(rd.ReadLine());
while (t-- > 0)
{
    var date = rd.ReadLine().Split();
    var year = date[0].Split('/')[2];
    DateTime date1 = DateTime.Parse(date[0]), date2 = DateTime.Parse(date[1] + "/" + year);
    int day = date1.Subtract(date2).Days;

    if (Math.Abs(day) >= 358)
    {
        date2 = date2.AddYears(day > 0 ? 1 : -1);
        day = date1.Subtract(date2).Days; 
    }

    if (Math.Abs(day) > 7)
        wt.WriteLine("OUT OF RANGE");
    else if (day == 0)
        wt.WriteLine("SAME DAY");
    else
        wt.WriteLine($"{date2.Month}/{date2.Day}/{date2.Year} IS {Math.Abs(day)} {(Math.Abs(day) == 1 ? "DAY" : "DAYS")} {(day > 0 ? "PRIOR" : "AFTER")}");
}