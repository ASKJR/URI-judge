'''
Problem: CPF 2
URI Online Judge | 1786
Solution developed by: Alberto Kato
'''


def getFirstCheckDigit(cpfNum):
    digit = 0
    for i in range(1, 10):
        digit = digit + (int(cpfNum[i - 1]) * i)
    if (digit % 11) == 10:
        return "0"
    else:
        return str((digit % 11))


def getSecondCheckDigit(cpfNum):
    digit = 0
    index = 0
    for i in range(9, 0, -1):
        digit = digit + (int(cpfNum[index]) * i)
        index = index + 1
    if (digit % 11) == 10:
        return "0"
    else:
        return str((digit % 11))


def formatedCpf(cpfNum):
    cpf = list(cpfNum)
    cpf.insert(3, '.')
    cpf.insert(7, '.')
    return "".join(cpf) + '-' + getFirstCheckDigit(cpfNum) + getSecondCheckDigit(cpfNum)


while True:
    try:
        cpfNum = input()
        print(formatedCpf(cpfNum))
    except EOFError:
        break
