using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
string c = rd.ReadLine() switch
{
    "M" => "MatKor",
    "W" => "WiCys",
    "C" => "CyKor",
    "A" => "AlKor",
    "$" => "$clear",
    _ => ""
};
wt.Write(c);