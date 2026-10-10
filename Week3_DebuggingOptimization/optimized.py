
import math


def is_prime(n):
    if n < 2:
        return False

    if n == 2:
        return True

    if n % 2 == 0:
        return False

    for i in range(3, math.isqrt(n) + 1, 2):
        if n % i == 0:
            return False

    return True


numbers = [-5, 0, 1, 2, 7, 10, 17, 25]

for num in numbers:
    print(num, "->", is_prime(num))
