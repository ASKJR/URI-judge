'''
Problem: Ordenação por Tamanho
URI Online Judge | 1244
Solution developed by: Alberto Kato
'''


def sortWordsByLen(phrase):
    phrase = phrase.split()
    orderedPhrase = []
    while(phrase):
        biggestWordIndex = 0
        for i in range(1, len(phrase) + 1):
            if len(phrase[biggestWordIndex]) < len(phrase[i - 1]):
                biggestWordIndex = i - 1
        orderedPhrase.append(phrase[biggestWordIndex])
        phrase.pop(biggestWordIndex)

    return " ".join(orderedPhrase)


N = int(input())

while N > 0:
    phrase = input()
    print(sortWordsByLen(phrase))
    N -= 1
