'''
Problem: Pouca Frequência
URI Online Judge | 1277
Solution developed by: Alberto Kato
'''


def getFrequency(frequency):
    P = 0
    A = 0
    for i in range(0, len(frequency)):
        if frequency[i] == 'M':
            continue
        elif frequency[i] == 'P':
            P += 1
        else:
            A += 1
    return P / (P + A)


T = int(input())

for i in range(0, T):
    N = int(input())
    students = input().split()
    frequency = input().split()
    studentsLowFrequency = []
    for j in range(0, len(students)):
        if getFrequency(frequency[j]) < 0.75:
            studentsLowFrequency.append(students[j])
    print(" ".join(studentsLowFrequency))
