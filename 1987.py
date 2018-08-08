'''
Problem: Divisibilidade Por 3
URI Online Judge | 1987
Solution developed by: Alberto Kato
'''

while True:
    try:
        n, m = input().split()
        n = int(n)
        tot = 0
        for i in range(0, n):
            tot += int(m[i])
        if (tot % 3) == 0:
            print(tot, 'sim')
        else:
            print(tot, 'nao')
    except EOFError:
        break
