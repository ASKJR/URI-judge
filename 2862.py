'''
Problem: Inseto!
URI Online Judge | 2862
Solution developed by: Alberto Kato
'''
N = int(input())

for i in range(0, N):
    ki = int(input())
    if ki > 8000:
        print("Mais de 8000!")
    else:
        print("Inseto!")
