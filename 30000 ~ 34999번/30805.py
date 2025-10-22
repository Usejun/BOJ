def find(a, b, r = []):
    if (not a) or (not b):
        return r
    am, bm = max(a), max(b)
    ami, bmi = a.index(am), b.index(bm)

    if am == bm:
        r.append(am)
        return find(a[ami+1:], b[bmi+1:], r)
    if am > bm:
        a.pop(ami)
    else:
        b.pop(bmi)
        
    return find(a, b, r)

n = int(input())
a = list(map(int, input().split()))
m = int(input())
b = list(map(int, input().split()))
mx = find(a, b)

print(len(mx))
if mx:
    print(*mx)
    
