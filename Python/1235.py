'''
Problem: De Dentro para Fora
URI Online Judge | 1235
Solution developed by: Alberto Kato
'''
N = int(input())

for i in range(0, N):
    phrase = input()
    halfPhraseIndex = int((len(phrase) / 2))
    phrasePiece1 = phrase[:halfPhraseIndex]
    phrasePiece2 = phrase[halfPhraseIndex:]
    decodedMsg = phrasePiece1[::-1] + phrasePiece2[::-1]
    print(decodedMsg)
