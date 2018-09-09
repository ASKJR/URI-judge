'''
Problem: Sentença Dançante
URI Online Judge | 1234
Solution developed by: Alberto Kato
'''


def dancingSentence(sentence):
    upper = False
    lower = False
    dancing = ''
    for i in range(0, len(sentence)):
        if sentence[i] == ' ':
            dancing += sentence[i]
        else:
            if not upper and not lower:
                upper = True
                dancing += sentence[i].upper()
            else:
                upper = False
                dancing += sentence[i].lower()
    return dancing


while True:
    try:
        sentence = input()
        print(dancingSentence(sentence))
    except EOFError:
        break
