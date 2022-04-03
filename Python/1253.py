'''
Problem: Cifra de César
URI Online Judge | 1253
Solution developed by: Alberto Kato
'''


def getShiftedLetter(letter, shiftRatio):
    loop = 0
    index = alphabet.index(letter)
    while loop < shiftRatio:
        index -= 1
        loop += 1
        if index < 0:
            index = 25
    return alphabet[index]


def decodeWord(word, shiftRatio):
    decodedWord = ''
    for letter in word:
        decodedWord += getShiftedLetter(letter, shiftRatio)
    return decodedWord


alphabet = ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z')

N = int(input())

for i in range(1, N + 1):
    word = input()
    shiftRatio = int(input())
    print(decodeWord(word, shiftRatio))
