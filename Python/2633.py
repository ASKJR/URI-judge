'''
Problem: Churras no Yuri
URI Online Judge | 2633
Solution developed by: Alberto Kato
'''
while True:
    try:
        n = int(input())
        items = []
        for x in range(0, n):
            p, e = input().split()
            items.append({"p": p, "e": int(e)})
        items = sorted(items, key=lambda i: i['e'])
        out = [item['p'] for item in items]
        print(' '.join(out))
    except EOFError:
        break
