'''
Problem: Sequência Espelho
URI Online Judge | 2157
Solution developed by: Alberto Kato
'''
C = int(input())

for i in range(0, C):
    B, E = [int(i) for i in input().split()]
    mirror = []
    for j in range(B, E + 1):
        numStr = str(j)
        mirror += list(numStr)
    print("".join(mirror) + "".join(mirror[::-1]))
