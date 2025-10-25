m, n = map(int, input().split())
u, l, r, d = map(int, input().split())
board = [['#' if j % 2 == 0 else '.' for j in range(l+r+n)] if i % 2 == 0 else ['.' if j % 2 == 0 else '#' for j in range(l+r+n)] for i in range(u+d+m)]
words = [input() for _ in range(m)]

for i in range(m):
    for j in range(n):
        board[i+u][l+j]=words[i][j]
        
print(*map(lambda x: ''.join(x), board), sep='\n')