'''
Problem: Entrada e Saída de Data
URI Online Judge | 2764
Solution developed by: Alberto Kato
'''
while True:
    try:
        date = input().split('/')
        DD = date[0]
        MM = date[1]
        AA = date[2]
        print(MM + '/' + DD + '/' + AA)
        print(AA + '/' + MM + '/' + DD)
        print(DD + '-' + MM + '-' + AA)
    except EOFError:
        break
