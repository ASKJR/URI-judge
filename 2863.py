'''
Problem: Umil Bolt
URI Online Judge | 2863
Solution developed by: Alberto Kato
'''
while True:
    try:
        T = int(input())
        bestTime = float(input())
        for dummy_i in range(1, T):
            time = float(input())
            if time < bestTime:
                bestTime = time
        print(bestTime)
    except EOFError:
        break
