'''
Problem: Entrada e Saída CPF
URI Online Judge | 2763
Solution developeded by: Alberto Kato
'''
while True:
    try:
        cpf = input()
        cpf = cpf.replace('-', '.')
        cpf = cpf.split('.')
        for out in cpf:
            print(out)
    except EOFError:
        break
