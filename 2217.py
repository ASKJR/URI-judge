'''
Problem: Nove
URI Online Judge | 2217
Solution developed by: Alberto Kato
'''

'''
function inspired by: https://www.geeksforgeeks.org/find-last-digit-of-ab-for-large-numbers/
'''


def getLastDigit(a, b):

    if b == 0:
        return 1
    else:
        b = 4 if (b % 4) == 0 else (b % 4)
        a = int(str(a)[-1])
        lastdigit = a**b
        return lastdigit % 10


T = int(input())
for n in range(0, T):
    N = int(input())
    print(getLastDigit(9, N))
