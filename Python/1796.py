'''
Problem: Economia Brasileira
URI Online Judge | 1796
Solution developed by: Alberto Kato
'''

Q = int(input())
V = input().split()
results = {'0': 0, '1': 0}
for x in V:
    results[x] += 1
if results['0'] >= 1 and (results['0'] / Q) > 0.5:
    print('Y')
else:
    print('N')
