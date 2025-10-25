n, k = map(int, input().split())
l = sorted(map(int, input().split()))

for i in range(k):
    a, b, d = map(int, input().split())
    idx = 0
    for j in range(a-1, b):
        l[j] += d
    if d < 0:
        l[:b] = sorted(l[:b])
    else:
        l[a-1:] = sorted(l[a-1:])
            
print(*l)
