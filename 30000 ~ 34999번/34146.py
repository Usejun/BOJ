n, m = map(int, input().split())
counting = {}
odd = 0

for i in range(n):
    for j in map(int, input().split()):
        if j not in counting:
            counting[j] = 0
        counting[j] += 1
        
for i in counting:
    if counting[i] % 2 == 1:
        odd += 1
        
print('YES' if (n if m % 2 == 1 else 0) - odd >= 0 else 'NO')