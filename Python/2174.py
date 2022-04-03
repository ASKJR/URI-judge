'''
Problem: Coleção de Pomekon
URI Online Judge | 2174
Solution developed by: Alberto Kato
'''
N = int(input())
pokemons = set()

for i in range(0, N):
    pokemons.add(input())

print("Falta(m)", (151 - len(pokemons)), "pomekon(s).")
