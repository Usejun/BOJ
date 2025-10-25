n = int(input())
stone = list(map(int, input().split()))
l, r, c = 0, 0, 0

for w in stone:
    if l > r:
        r += w
    else:
        l += w

weight = max(l, r) - min(l, r)
for i in [100, 50, 20, 10, 5, 2, 1]:
    c += weight // i
    weight %= i
    
print(c)