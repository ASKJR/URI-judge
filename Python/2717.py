'''
Problem: Tempo do Duende
URI Online Judge | 2717
Solution developed by: Alberto Kato
'''
N = int(input())
A, B = [int(i) for i in input().split()]
if A + B <= N:
    print('Farei hoje!')
else:
    print('Deixa para amanha!')
