'''
Problem: Evento
URI Online Judge | 2172
Solution developed by: Alberto Kato
'''
while True:
    x, m = [int(i) for i in input().split()]
    if (x == 0 and m == 0):
        break
    print(x*m)
