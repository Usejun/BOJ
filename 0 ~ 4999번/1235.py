n = int(input())
names = [input() for _ in range(n)]
m = 0
cut = set()

while len(cut) != n:
    cut.clear()
    m += 1
    
    for name in names:
        cut.add(name[-m:])

print(m)
