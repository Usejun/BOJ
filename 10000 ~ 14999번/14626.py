even = False
total = 0
map = [0, 3, 6, 9, 2, 5, 8, 1, 4, 7]
for i, x in enumerate(input()):
    if x == '*':
        even = True if i % 2 == 0 else False
    else:
        total += (1 if i % 2 == 0 else 3) * int(x)
print(10 - total % 10 if even else map[total % 10])
