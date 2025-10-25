n = int(input())
data = list(map(int, input().split()))
sticker = set()
count = 0
mx = 0

for i in data:
    if i in sticker:
        count -= 1
    else:
        sticker.add(i)
        count += 1
    mx = max(mx, count)
    
print(mx)