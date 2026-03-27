import sys

print = sys.stdout.write
input = sys.stdin.readline

n, m = map(int, input().split())
scores = []

for i in range(n):
    style, score = input().split()    
    scores.append((style, int(score)))
        
for i in range(m):
    k = int(input())
    a, b = 0, n - 1
    
    while a < b:
        mid = a + (b - a) // 2
        if k <= scores[mid][1]:
            b = mid 
        else:
            a = mid + 1
            
    print(scores[b][0])
    print('\n')
