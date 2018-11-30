'''
Problem: Bilhetes Falsos
URI Online Judge | 1318
Solution developed by: Alberto Kato
'''
import collections

while True:
    N, M = input().split()
    out = 0
    if N == '0' and M == '0':
        break
    package = input().split()
    counter = collections.Counter(package)
    for tot in counter.values():
        if tot > 1:
            out += 1
    print(out)
