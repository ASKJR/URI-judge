'''
Problem: Virus
URI Online Judge | 2567
Solution developed by: Alberto Kato
'''
while True:
    try:
        N = input()
        virusAge = [int(i) for i in input().split()]
        lethality = 0
        while len(virusAge) >= 2:
            oldest = max(virusAge)
            yougest = min(virusAge)
            virusAge.remove(oldest)
            virusAge.remove(yougest)
            lethality += (oldest - yougest)
        print(lethality)
    except EOFError:
        break
