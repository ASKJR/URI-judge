'''
Problem: Reservatório de Mel
URI Online Judge | 2029
Solution developed by: Alberto Kato
'''
PI = 3.14


def getCylinderHeight(volume, radius):
    return format((volume/(PI*(radius*radius))), '.2f')


def getCircleArea(radius):
    return format((PI*(radius*radius)), '.2f')


while True:
    try:
        volume = float(input())
        radius = (float(input()))/2
        print("ALTURA =", getCylinderHeight(volume, radius))
        print("AREA =", getCircleArea(radius))
    except EOFError:
        break
