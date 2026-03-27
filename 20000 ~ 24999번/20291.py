n = int(input())
exts = {}

for i in range(n):
    file = input()
    ext = file.split('.')[1]
    if ext in exts:
        exts[ext] += 1
    else:
        exts[ext] = 1
        
for ext in sorted(exts.keys()):
    print(ext, exts[ext])
