'''
Problem: Gangorra
URI Online Judge | 2455
Solution developed by: Alberto Kato
'''
P1, C1, P2, C2 = [int(i) for i in input().split()]
E = P1 * C1
D = P2 * C2

if E == D:
    print(0)
elif E > D:
    print(-1)
else:
    print(1)
