'''
Problem: Array Hash
URI Online Judge | 1257
Solution developed by: Alberto Kato
'''
alphabet = ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z')
N = int(input())

for i in range(0, N):
    L = int(input())
    hashCode = 0
    for j in range(0, L):
        code = input()
        for k in range(0, len(code)):
            hashCode += alphabet.index(code[k]) + j + k
    print(hashCode)
