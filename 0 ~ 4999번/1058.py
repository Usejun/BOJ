n = int(input())
l = [list(map(lambda x: int(1e9) if x == 'N' else 1, input())) for _ in range(n)]

for x in range(n):
    for y in range(n):
        for z in range(n):
            if x != z:
                l[x][z] = min(l[x][z], l[x][y] + l[y][z])
      
          
print(0 if n < 2 else max(*map(lambda x: len(list(filter(lambda y: y < 3, x))), l)))