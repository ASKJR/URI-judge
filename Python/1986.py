'''
Problem: Perdido em Marte
URI Online Judge | 1986
Solution developed by: Alberto Kato
'''

n = input()
hexMessage = input().replace(" ", "")
print(bytearray.fromhex(hexMessage).decode())
