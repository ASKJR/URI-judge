'''
Problem: A Biblioteca do Senhor Severino
URI Online Judge | 2137
Solution developed by: Alberto Kato
'''
while True:
    try:
        N = int(input())
        nums = []
        for i in range(0, N):
            nums.append(input())
        print("\n".join(sorted(nums)))
    except EOFError:
        break
