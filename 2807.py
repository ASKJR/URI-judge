'''
Problem: Iccanobif
URI Online Judge | 2807
Solution developeded by: Alberto Kato
'''
def fib(n):
    previus = 0
    current = 1
    fibSequence = []
    fibSequence.append(current)
    for i in range(1, n):
        n = previus + current
        fibSequence.append(n)
        previus = current
        current = n
    return fibSequence


sequenceSize = int(input())
fibSequence = list(map(str, fib(sequenceSize)))[::-1]
print(" ".join(fibSequence))
