var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], answer = -1;
var w = new int[n+1];
var v = Console.ReadLine().Split().Select(int.Parse).ToArray();
Sort(0, n - 1);
Console.Write(answer);

void Merge(int left, int mid, int right)
{
    int i = left, j = mid + 1, k = left, l = 0;

    while (i <= mid && j <= right)
    {
        if (v[i] <= v[j])
            w[k++] = v[i++];
        else
            w[k++] = v[j++];
    }

    if (i > mid)
        for (l = j; l <= right; l++)
            w[k++] = v[l];
    else
        for (l = i; l <= mid; l++)
            w[k++] = v[l];

    for (l = left; l <= right; l++)
    {
        m--;
        if (m == 0)
            answer = w[l];
        v[l] = w[l];
    }
}

void Sort(int left, int right)
{
    if (left < right)
    {
        int mid = (left + right) / 2;
        Sort(left, mid);
        Sort(mid + 1, right);
        Merge(left, mid, right);
    }
}