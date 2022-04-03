'''
Problem: Conversão Simples de Base
URI Online Judge | 1199
Solution developed by: Alberto Kato
'''
while True:
    num = input()
    if "x" in num:
        print(int(num[2:], 16))
    else:
        num = int(num)
        if num < 0:
            break
        else:
            num = str(hex(num))[2:].upper()
            print("0x" + num)
