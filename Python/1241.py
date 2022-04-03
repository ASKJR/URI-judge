'''
Problem: Encaixa ou Não II
URI Online Judge | 1241
Solution developed by: Alberto Kato
'''
N = int(input())
for i in range(0, N):
    A, B = input().split()
    if len(A) >= len(B):
        if A[-len(B):] == B:
            print('encaixa')
        else:
            print('nao encaixa')
    else:
        print('nao encaixa')
