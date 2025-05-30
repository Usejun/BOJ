n = int(input())
l = list(map(int, input().split()))
k = 0

def dp(a, b):
    m = [0 for _ in range(n+1)]
    for i in range(1, n+1):
        if l[i-1] == a or l[i-1] == b:
            m[i] = m[i - 1] + 1
    return max(m)

for i in range(1, 9):
    for j in range(i+1, 10):
        k = max(k, dp(i, j))

print(k)
