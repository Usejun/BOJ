import sys

input = sys.stdin.readline
t = int(input())
fib = [1, 2]
mod = int(1e9)+7

for i in range(2, 191229+1):
    fib.append((fib[i-1] + fib[i-2]) % mod)
    
for _ in range(t):
    print(fib[int(input()) - 1])
    