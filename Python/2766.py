'''
Problem: Entrada e Saída Lendo e Pulando Nomes
URI Online Judge | 2766
Solution developed by: Alberto Kato
'''
while True:
    try:
        names = []
        for i in range(1, 11):
            names.append(input())
        print(names[2])
        print(names[6])
        print(names[8])
    except EOFError:
        break
