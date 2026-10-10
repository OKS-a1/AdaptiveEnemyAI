
import unittest
from optimized import is_prime


class TestPrime(unittest.TestCase):
    def test_numbers_below_two(self):
        for n in [-10, -1, 0, 1]:
            self.assertFalse(is_prime(n))

    def test_small_primes(self):
        for n in [2, 3, 5, 7, 11, 17]:
            self.assertTrue(is_prime(n))

    def test_composite_numbers(self):
        for n in [4, 6, 9, 10, 25, 100]:
            self.assertFalse(is_prime(n))

    def test_large_prime(self):
        self.assertTrue(is_prime(104729))

    def test_large_composite(self):
        self.assertFalse(is_prime(104730))


if __name__ == "__main__":
    unittest.main()
