txt = input()
l = len(txt)
fl = ''
sl = ''
ml = ''

for i in range(1, l+1):
    fl += '*' if i % 3 == 0 else '#'
    fl += '...' if i != l else ''
    sl += '*.*' if i % 3 == 0 else '#.#'
    sl += '.' if i != l else ''
    ml += f'{('*' if i % 3 == 0 or (i != 1 and (i-1) % 3 == 0) else '#')}.{txt[i-1]}.'
    ml += ('*' if i % 3 == 0 else '#') if i == l else ''

print(f'..{fl}..')
print(f'.{sl}.')
print(ml)
print(f'.{sl}.')
print(f'..{fl}..')