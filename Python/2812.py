'''
Problem: Laércio
URI Online Judge | 2812
Solution developed by: Alberto Kato
'''


def order(items):
    listToReturn = []
    while items:
        maxValue = max(items)
        items.remove(maxValue)
        listToReturn.append(maxValue)
        if items:
            minValue = min(items)
            items.remove(minValue)
            listToReturn.append(minValue)
    return listToReturn


N = int(input())
loop = 0
while loop < N:
    loop += 1
    M = int(input())
    nums = [int(i) for i in input().split() if int(i) % 2 != 0]
    print(" ".join(map(str, order(nums))))
