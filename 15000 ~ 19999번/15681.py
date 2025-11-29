import sys
sys.setrecursionlimit(10 ** 7)
input = sys.stdin.readline
print = sys.stdout.write

def make_tree(node):
    global tree, nodes, visit
    visit[node] = True

    for subnode in nodes[node]:
        if not visit[subnode]:
            tree[node].append(subnode)
            make_tree(subnode)

def count_subtree(node):
    global dp
    if dp[node] != 0:
        return dp[node]
    dp[node] = 1
    
    for subnode in tree[node]:
        dp[node] += count_subtree(subnode)
        
    return dp[node]

n, r, q = map(int, input().split())
nodes = [list() for _ in range(n+1)]
tree = [list() for _ in range(n+1)]
visit = [False for _ in range(n+1)]
dp = [0 for _ in range(n+1)]

for _ in range(n - 1):
    a, b = map(int, input().split())
    nodes[a].append(b)
    nodes[b].append(a)
    
make_tree(r)
count_subtree(r)

for _ in range(q):
    print(f"{dp[(int(input()))]}\n")