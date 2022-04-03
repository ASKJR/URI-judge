'''
Problem: Frase Completa
URI Online Judge | 1551
Solution developed by: Alberto Kato
'''
N = int(input())

for i in range(0, N):
    phraseLen = len(set(input().replace(",", "").replace(" ", "")))

    if phraseLen >= 26:
        print("frase completa")
    elif phraseLen >= 13:
        print("frase quase completa")
    else:
        print("frase mal elaborada")
