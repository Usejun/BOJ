def bits(n):
    if n < 0:
        return 0
    result = 0
    while n > 0:
        top = n.bit_length() - 1
        p = 1 << top
        k = n - p
           
        if top > 0:
           result += (1 << (top - 1)) * top
        result += k + 1
        n = k
    return result

a, b = map(int, input().split())
print(bits(b) - bits(a - 1))
