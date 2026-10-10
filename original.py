
def is_prime(n):
    if n == 2:
        return True

    for i in range(2, n):
        if n % i == 0:
            return False

    return True


numbers = [-5, 0, 1, 2, 7, 10, 17, 25]

for num in numbers:
    print(num, "->", is_prime(num))
