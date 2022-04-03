'''
Problem: Validador de Senhas
URI Online Judge | 2253
Solution developed by: Alberto Kato
'''
while True:
    try:
        upper = False
        lower = False
        num = False
        S = input()
        if len(S) >= 6 and len(S) <= 32 and S.isalnum():
            for letter in S:
                if letter.isupper():
                    upper = True
                if letter.islower():
                    lower = True
                if letter.isnumeric():
                    num = True
            if upper and lower and num:
                print('Senha valida.')
            else:
                print('Senha invalida.')
        else:
            print('Senha invalida.')
    except EOFError:
        break
