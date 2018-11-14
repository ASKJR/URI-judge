'''
Problem: Jogatina UFPR
URI Online Judge | 2543
Solution developed by: Alberto Kato
'''
while True:
    try:
        N, USER_ID = [int(x) for x in input().split()]
        gameplays = 0
        for i in range(0, N):
            ID, GAME_TYPE = [int(x) for x in input().split()]
            if ID == USER_ID and GAME_TYPE == 0:
                gameplays = gameplays + 1
        print(gameplays)
    except EOFError:
        break
