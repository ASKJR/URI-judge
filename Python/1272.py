'''
Problem: Mensagem Oculta
URI Online Judge | 1272
Solution developed by: Alberto Kato
'''
N = int(input())

for i in range(0, N):
    msg = input().split()
    if msg:
        decodedMsg = []
        for word in msg:
            decodedMsg.append(word[0])
        print("".join(decodedMsg))
    else:
        print()
