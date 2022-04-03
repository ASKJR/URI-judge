'''
Problem: Loteria
URI Online Judge | 2473
Solution developed by: Alberto Kato
'''

prizes = {3: 'terno', 4: 'quadra', 5: 'quina', 6: 'sena'}


def checkForPrize(userBet, sortedNumbers):
    score = 0
    for bet in userBet:
        if bet in sortedNumbers:
            score += 1

    return prizes.get(score, 'azar')


userBet = input().split()
sortedNumbers = input().split()

print(checkForPrize(userBet, sortedNumbers))
