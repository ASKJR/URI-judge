'''
Problem: Criptotexto
URI Online Judge | 2866
Solution developed by: Alberto Kato
'''
n = int(input())

for i in range(0, n):
    message = input()
    decoded_message = ""
    for letter in message:
        if letter.islower():
            decoded_message += letter
    print(decoded_message[::-1])
