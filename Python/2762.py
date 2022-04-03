'''
Problem: Entrada e Saída 6
URI Online Judge | 2762
Solution developed by: Alberto Kato
'''
n1, n2 = input().split('.')
if n1 == (len(n1) * '0') and (n2 == len(n2) * '0'):
    print('0.0')
else:
    num = n2.lstrip('0') + '.' + n1
    print(num)
