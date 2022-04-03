'''
Problem: Borboletas
URI Online Judge | 1901
Solution developed by: Alberto Kato
'''

matrix = []
uniqueItems = set()

N = int(input())

for i in range(0, N):
    line = input().split()
    matrix.append(line)

for i in range(0, N * 2):
    l, c = [int(i) for i in input().split()]
    uniqueItems.add(matrix[l - 1][c - 1])

print(len(uniqueItems))
