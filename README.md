# Adaptive Enemy AI

A game development project repository documenting practical work in enemy AI, debugging, and performance optimization as part of the Yuva-Intern Junior Game Developer internship.

## Projects

### Week 1: Adaptive Enemy AI — Unity

A Unity-based game prototype focused on adaptive enemy behaviour.

**Key areas:**
- Enemy patrol and chase behaviour
- Search behaviour and enemy memory
- Adaptive AI behaviour design

**Technologies:** Unity, C#

### Week 3: Debugging and Performance Optimization — Python

A Python project demonstrating debugging, correctness testing, and algorithm optimization through a prime number checker.

**Key areas:**
- Fixing incorrect prime-number classification
- Optimizing trial division using the square-root limit
- Automated testing with Python's `unittest`
- Benchmarking original and optimized implementations

**Folder:** `Week3_DebuggingOptimization/`

**Technologies:** Python 3.10+, `unittest`, `time`

## Repository Structure

```text
AdaptiveEnemyAI/
├── Assets/
├── Packages/
├── ProjectSettings/
├── Week3_DebuggingOptimization/
│   ├── original.py
│   ├── optimized.py
│   ├── test_prime.py
│   ├── benchmark.py
│   └── README.md
├── .gitignore
└── README.md
```

## Running the Week 3 Project

Open a terminal inside `Week3_DebuggingOptimization/`.

Run the optimized implementation:

```bash
python optimized.py
```

Run the automated tests:

```bash
python -m unittest -v test_prime.py
```

Run the performance benchmark:

```bash
python benchmark.py
```

## Purpose

This repository records practical learning and implementation across game AI development, software debugging, testing, and algorithm optimization.
