import sys
from bisect import bisect_right

print = sys.stdout.write
input = sys.stdin.readline

t = int(input())

while (t:=t-1) >= 0:
    n = int(input())
    m = n // 10 + (0 if n % 10 == 0 else 1)
    l1 = []
    l2 = []
    med = []
    
    for i in range(m):
        l1.extend(map(int, input().split()))
        
    for i in range(n):
        l2.insert(bisect_right(l2, l1[i]), l1[i])
        if i % 2 == 0:
            med.append(l2[len(l2) // 2])
    
    n = len(med)
    m = n // 10 + (0 if n % 10 == 0 else 1)
    print(str(n))
    print('\n')
    for i in range(m):
        print(' '.join(map(str, med[i*10:min((i+1)*10, n)])))
        print('\n')
    
