'''
Problem: Teclado Zoeiro
URI Online Judge | 2692
Solution developed by: Alberto Kato
'''
letters = {}

N, M = [int(x) for x in input().split()]

for i in range(0, N):
    E, S = input().split()
    letters[E] = S
    letters[S] = E

for j in range(0, M):
    phrase = input()
    decodedPhrase = ""
    for letter in phrase:
        replaceLetter = letters.get(letter)
        if replaceLetter is not None:
            decodedPhrase += replaceLetter
        else:
            decodedPhrase += letter
    print(decodedPhrase)
