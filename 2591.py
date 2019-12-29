'''
Problem: HameKameKa
URI Online Judge | 2591
Solution developed by: Alberto Kato
'''
N = int(input())

for i in range(0, N):
    word = input().split('k')
    repeat = word[0].count('a')*word[1].count('a')
    print('k' + ('a'*repeat))
