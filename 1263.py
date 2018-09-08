'''
Problem: Aliteração
URI Online Judge | 1263
Solution developed by: Alberto Kato
'''
"He has four fanatic fantastic fans"
while True:
    try:
        phrase = input().split()
        aliteracao = 0
        firstWordLetter = phrase[0][0].lower()
        x = ''
        for i in range(1, len(phrase)):
            if phrase[i][0].lower() == firstWordLetter:
                if x != firstWordLetter:
                    aliteracao += 1
                    x = firstWordLetter

            else:
                firstWordLetter = phrase[i][0].lower()
                x = ''
        print(aliteracao)
    except EOFError:
        break
