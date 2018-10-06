'''
Problem: Qual o Mais Rápido?
URI Online Judge | 2175
Solution developed by: Alberto Kato
'''

O, B, I = [float(x) for x in input().split()]

timingRecord = {"Otavio": O, "Bruno": B, "Ian": I}
timingRecord = sorted(timingRecord.items(), key=lambda x: x[1])

if timingRecord[0][1] == timingRecord[1][1]:
    print("Empate")
else:
    print(timingRecord[0][0])
