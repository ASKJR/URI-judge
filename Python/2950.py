'''
Problem: As Duas Torres
URI Online Judge | 2950
Solution developed by: Alberto Kato
'''
info = input().split()
distance = int(info[0])
diameter1 = int(info[1])
diameter2 = int(info[2])
out = distance / (diameter1 + diameter2)

print("{:.2f}".format(out))
