'''
Problem: Carnaval
URI Online Judge | 2418
Solution developed by: Alberto Kato
'''

scores = [float(i) for i in input().split()]
scores.remove(max(scores))
scores.remove(min(scores))
print(round(sum(scores), 1))
