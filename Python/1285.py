'''
Problem: Dígitos Diferentes
URI Online Judge | 1285
Solution developed by: Alberto Kato
'''
while True:
    try:
        N, M = [int(x) for x in input().split()]
        tot = 0
        for i in range(N, M+1):
            if len(set(str(i))) == len(str(i)):
                tot = tot + 1
        print(tot)
    except EOFError:
        break
