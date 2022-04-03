'''
Problem: A Sociedade do Anel
URI Online Judge | 2949
Solution developed by: Alberto Kato
'''
report = {'A': 0, 'E': 0, 'H': 0, 'M': 0, 'X': 0}

N = int(input())

for i in range(0, N):
    data = input().split()
    index = data[1]
    report[index] += 1

print(report['X'], "Hobbit(s)")
print(report['H'], "Humano(s)")
print(report['E'], "Elfo(s)")
print(report['A'], "Anao(s)")
print(report['M'], "Mago(s)")
