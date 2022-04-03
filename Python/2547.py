'''
Problem: Montanha-Russa
URI Online Judge | 2547
Solution developed by: Alberto Kato
'''
while True:
    try:
        N, A_MIN, A_MAX = [int(x) for x in input().split()]
        allowed = 0
        for i in range(0, N):
            height = int(input())
            if height >= A_MIN and height <= A_MAX:
                allowed = allowed + 1
        print(allowed)
    except EOFError:
        break
