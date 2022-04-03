'''
Problem: Maior Número de Um Algarismo
URI Online Judge | 1867
Solution developed by: Alberto Kato
'''


def oneDigitNotation(numStr):
    if len(numStr) == 1:
        return int(numStr)
    while len(numStr) != 1:
        numInt = 0
        for i in numStr:
            numInt += int(i)
            numStr = str(numInt)
    return int(numStr)


def getMax(N1, N2):
    if N1 > N2:
        return 1
    elif N2 > N1:
        return 2
    else:
        return 0


while True:
    N1, N2 = input().split()

    if N1 == '0' and N2 == '0':
        break
    N1 = oneDigitNotation(N1)
    N2 = oneDigitNotation(N2)

    print(getMax(N1, N2))
