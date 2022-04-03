'''
Problem: Digitador Gago
URI Online Judge | 2815
Solution developed by: Alberto Kato
'''


def removeRedundancy(word):
    if word[0] == word[2] and word[1] == word[3]:
        return word[2:]
    else:
        return word


text = input().split()

for i in range(0, len(text)):
    if len(text[i]) >= 4:
        text[i] = removeRedundancy(text[i])

print(" ".join(text))
