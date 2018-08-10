'''
Problem: Construindo Muralhas
URI Online Judge | 2650
Solution developed by: Alberto Kato
'''
highest = []

N, W = [int(i) for i in input().split()]

for i in range(0, N):
    titanInfoStr = input()
    titanInfoList = titanInfoStr.split()
    titanHeight = int(titanInfoList[len(titanInfoList) - 1])
    if titanHeight > W:
        out = titanInfoList[0]
        for j in range(1, len(titanInfoList) - 1):
            out += " " + titanInfoList[j]
        highest.append(out)

for i in range(0, len(highest)):
    print(highest[i])
