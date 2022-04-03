'''
Problem: Feynman
URI Online Judge | 1323
Solution developed by: Alberto Kato
'''
# n(n+1)(2n+1)/6 == 1^2 + 2^2 + ... n^2

while True:
    n = int(input())
    if not n:
        break
    out = int((n*(n+1)*(2*n+1))/6)
    print(out)
