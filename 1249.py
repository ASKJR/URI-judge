'''
Problem: Rot13
URI Online Judge | 1249
Solution developed by: Alberto Kato
'''
import string as s

alphabet = s.ascii_lowercase


def rot13(letter):
    isUpper = False
    if not letter.isalpha():
        return letter
    if letter.isupper():
        isUpper = True
    index = alphabet.find(letter.lower())
    for dummy_i in range(0, 13):
        if index == 25:
            index = 0
        else:
            index += 1
    if isUpper:
        return alphabet[index].upper()
    else:
        return alphabet[index]


while True:
    try:
        phrase = input()
        decoded = ""
        for i in range(0, len(phrase)):
            decoded += rot13(phrase[i])
        print(decoded)
    except EOFError:
        break
