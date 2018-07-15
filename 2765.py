'''
Problem: Entrada e Saída com Virgula
URI Online Judge | 2765
Solution developed by: Alberto Kato
'''
while True:
    try:
        phrase = input().split(',')
        print(phrase[0])
        print(phrase[1])
    except EOFError:
        break
