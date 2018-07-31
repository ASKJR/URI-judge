'''
Problem: Composição de Jingles
URI Online Judge | 1430
Solution developed by: Alberto Kato
'''

noteDuration = {'W': 1, 'H': 1 / 2, 'Q': 1 / 4, 'E': 1 / 8, 'S': 1 / 16, 'T': 1 / 32, 'X': 1 / 64}


def isCompassDurationOk(compass):
    duration = 0
    for note in compass:
        duration += noteDuration[note]
    if duration == 1:
        return True
    else:
        return False


while True:
    composition = input()
    if composition == '*':
        break
    compassOkTotal = 0
    composition = composition[1:len(composition) - 1].split('/')
    for compass in composition:
        if isCompassDurationOk(compass):
            compassOkTotal += 1
    print(compassOkTotal)
