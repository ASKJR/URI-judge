'''
Problem: Problema com a Calculadora
URI Online Judge | 2694
Solution developed by: Alberto Kato
'''

N = int(input())

for i in range(0, N):
    line = input()
    response = int(line[2:4]) + int(line[5:8]) + int(line[11:13])
    print(response)
