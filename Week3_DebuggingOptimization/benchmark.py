
import timeit
import original
from optimized import is_prime


def old_is_prime(n):
    if n == 2:
        return True
    for i in range(2, n):
        if n % i == 0:
            return False
    return True


number = 104729
runs = 100

old_time = timeit.timeit(
    lambda: old_is_prime(number), number=runs
)

new_time = timeit.timeit(
    lambda: is_prime(number), number=runs
)

print(f"Number tested: {number}")
print(f"Runs: {runs}")
print(f"Original average: {old_time / runs:.6f} seconds")
print(f"Optimized average: {new_time / runs:.6f} seconds")

if new_time > 0:
    print(f"Speedup: {old_time / new_time:.2f}x")
