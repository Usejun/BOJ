using StreamWriter w = new(Console.OpenStandardOutput());
while (true)
{
    try
    {        
        int n = int.Parse(Console.ReadLine());
        int k = (int)Math.Pow(3, n);
        F(0, k, true);
        w.WriteLine();

        void F(int a, int b, bool e)
        {
            if (b - a == 1)
            {
                w.Write('-');
                return;
            }
            if (b - a == 3)
            {
                w.Write(e ? "- -" : "   ");
                return;
            }

            F(a, a + (b - a) / 3, e && true);
            F(a + (b - a) / 3, a + 2 * (b - a) / 3, false);
            F(a + 2 * (b - a) / 3, b, e && true);
        }
    }
    catch
    {
        w.Close();
        break;
    }
}