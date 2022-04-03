'''
Problem: Falha do Motor
URI Online Judge | 2167
Solution developed by: Alberto Kato
'''

N = int(input())
speeds = [int(x) for x in input().split()]
speed = speeds[0]
index = 0
for i in range(1, len(speeds)):
    if speed > speeds[i]:
        index = i + 1
        break
    else:
        speed = speeds[i]
print(index)
