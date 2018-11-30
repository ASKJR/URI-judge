'''
Problem: Papagaio Poliglota
URI Online Judge | 2850
Solution developed by: Alberto Kato
'''
languages = {'esquerda': 'ingles', 'direita': 'frances',
             'nenhuma': 'portugues', 'as duas': 'caiu'}
while True:
    try:
        print(languages[input()])
    except EOFError:
        break
