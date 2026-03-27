n, m = map(int, input().split())
a = list(map(int, input().split()))
cnt = {}
mx, cur = 1, 0

for i in range(n):
    if a[i] not in cnt:
        cnt[a[i]] = 0
    cnt[a[i]] += 1    
    if cnt[a[i]] <= m:
        mx = max(mx, i - cur + 1)
    else:
        while cnt[a[i]] > m:
            cnt[a[cur]] -= 1
            cur += 1
print(mx) 
