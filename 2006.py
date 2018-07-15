'''
Problem: Identificando o Chá
URI Online Judge | 2006
Solution developed by: Alberto Kato
'''
score = 0
T = input()
for i in input().split():
    if i == T:
        score += 1
print(score)
