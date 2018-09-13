'''
Problem: Atalhos Bloggo
URI Online Judge | 1239
Solution developed by: Alberto Kato
'''
while True:
    try:
        phrase = list(input())
        clearPhrase = []
        secondUnderscore = False
        secondAsterisk = False
        for letter in phrase:
            if letter == '_':
                if secondUnderscore:
                    clearPhrase.append('</i>')
                    secondUnderscore = False
                else:
                    clearPhrase.append('<i>')
                    secondUnderscore = True
            elif letter == '*':
                if secondAsterisk:
                    clearPhrase.append('</b>')
                    secondAsterisk = False
                else:
                    clearPhrase.append('<b>')
                    secondAsterisk = True
            else:
                clearPhrase.append(letter)
        print("".join(clearPhrase))
    except EOFError:
        break















