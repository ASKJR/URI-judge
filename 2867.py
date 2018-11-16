'''
Problem: Dígitos
URI Online Judge | 2867
Solution developed by: Alberto Kato
'''
while True:
    try:
        C = int(input())
        for dummy_i in range(0, C):
            N, M = [int(x) for x in input().split()]
            print(len(str(N**M)))
    except EOFError:
        break
