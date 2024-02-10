var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
long sum = 1;

for (int i = 1; i <= input[1]; i++) sum += (1L << i);

Console.Write(input[0] <= sum ? "yes" : "no");