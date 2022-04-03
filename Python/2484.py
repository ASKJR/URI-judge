'''
Problem: Abracadabra
URI Online Judge | 2484
Solution developed by: Alberto Kato
'''

while True:
    try:
        word = input()
        for x in range(len(word), 0, -1):
            print(" " * (len(word) - x) + " ".join(word[0:x]))
        print()
    except EOFError:
        break
