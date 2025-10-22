C, N = map(int, input().split())
cities = [list(map(int, input().split())) for _ in range(N)]
dp = [1e7 for _ in range(C + 100)]
dp[0] = 0

for cost, people in cities:
  for i in range(people,C + 100):
    dp[i] = min(dp[i - people] + cost, dp[i]) 

print(min(dp[C:]))
