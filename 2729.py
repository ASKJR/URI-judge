'''
Problem: Lista de Compras
URI Online Judge | 2729
Solution developed by: Alberto Kato
'''
N = int(input())
for i in range(1, N + 1):
    items = []
    for item in input().split():
        items.append(item)
    print(" ".join(sorted(list(set(items)))))
