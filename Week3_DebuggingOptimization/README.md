

\# Week 3: Debugging and Performance Optimization



\## Project Overview

This project demonstrates debugging and optimization using a Python prime number checker. The original implementation incorrectly classified numbers below 2 as prime and checked unnecessary divisors.



\## Files

\- `original.py` — Original implementation with the identified bug.

\- `optimized.py` — Corrected implementation using efficient trial division.

\- `test\_prime.py` — Automated correctness tests.

\- `benchmark.py` — Compares execution times of the original and optimized algorithms.



\## Requirements

\- Python 3.10 or later

\- No third-party packages required.



\## Run the Original Version

```bash

python original.py

```



\## Run the Optimized Version

```bash

python optimized.py

```



\## Run Automated Tests

```bash

python -m unittest -v test\_prime.py

```



\## Run the Benchmark

```bash

python benchmark.py

```



\## Improvements

1\. Correctly returns `False` for values below 2.

2\. Handles 2 as a special prime number.

3\. Rejects even composite numbers immediately.

4\. Checks odd divisors only up to the integer square root.

5\. Includes automated tests and a repeatable benchmark.



\## Benchmark Note

The recorded local benchmark used the prime number 104729 for 100 runs. The observed results are environment-dependent and may vary across systems.



\## Limitations

The benchmark is a small local experiment. Further repeated measurements under controlled conditions are recommended for rigorous comparisons.



\## Future Improvements

\- Add type hints and input validation.

\- Expand automated and randomized tests.

\- Repeat benchmarks and compare stable timing statistics.

\- Explore sieve-based algorithms for many prime queries.

