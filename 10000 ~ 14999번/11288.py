n, a, b = map(int, input().split())
txt = input()
offset = 1

for i in range(b):
    offset *= a
    offset %= 26
    
for char in txt:   
    if char == ' ':
        print(' ', end='')
    else:
        k = ord(char) - offset
        if k < 65:
            k = 91 - (65 - k)
        print(chr(k), end='') 