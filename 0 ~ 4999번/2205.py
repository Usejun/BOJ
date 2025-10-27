n = int(input())
use = [0 for _ in range(n+1)]

def two(k):
    for i in range(1, 15):
        a = (2 ** i) - k
        if a <= 0 or a > n:
            continue
        if use[a] == 0:
            use[k], use[a] = a, k

for i in range(n, 0, -1):
    if use[i] == 0:
        two(i)

print(*use[1:], sep='\n')

# 1 2 3 4 5 6 7
# 1 2 3 4 5 6 7

# 1 2 5 4 3
# 1 6 5 4 3 2  
# 7 6 5 4 3 2 1