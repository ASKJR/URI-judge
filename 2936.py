'''
Problem: Quanta Mandioca?
URI Online Judge | 2936
Solution developed by: Alberto Kato
'''

portion = [300, 1500, 600, 1000, 150]
out = 225

for i in range(0, len(portion)):
    qty = int(input())
    out += (portion[i]*qty)
print(out)
