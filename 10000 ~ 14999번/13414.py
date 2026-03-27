import sys

print = sys.stdout.write
input = sys.stdin.readline

n, m = map(int, input().split())
students = {}
k = 1

for i in range(m):
    students[input()] = k
    k += 1

print("".join(map(lambda y: str(y[0]), sorted(students.items(), key=lambda x: x[1])[:n])))
