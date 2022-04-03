'''
Problem: Frequência de Letras
URI Online Judge | 1255
Solution developed by: Alberto Kato
'''

N = int(input())
for i in range(0, N):
    txtLine = input().lower()
    letters = {}
    for letter in txtLine:
        if letter.isalpha():
            if letter not in letters:
                letters[letter] = 1
            else:
                letters[letter] += 1
    letters = sorted(letters.items(), key=lambda kv: kv[1], reverse=True)
    output = []
    output.append(letters[0][0])
    for i in range(1, len(letters)):
        if letters[i][1] == letters[0][1]:
            output.append(letters[i][0])
        else:
            break
    output.sort()
    print("".join(output))
