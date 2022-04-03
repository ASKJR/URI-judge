'''
Problem: O Retorno do Rei
URI Online Judge | 2951
Solution developed by: Alberto Kato
'''

N, G = [int(i) for i in input().split()]
values = {}
for i in range(0, N):
    R, V = input().split()
    V = int(V)
    values.update({R: V})
X = input()
out = 0

for letter in input().split():
    out += values[letter]

print(out)

if out >= G:
    print('You shall pass!')
else:
    print('My precioooous')
