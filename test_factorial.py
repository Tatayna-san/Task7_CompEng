import pytest

def factorial(n):
    if n == 1:
        return 1
    elif n == 0:
        return 1
    else:
        return n * factorial(n-1)

if __name__ == '__main__':
    print(factorial(10))

def test_factorial1():
    assert factorial(1) == 1

def test_factorial5():
    assert factorial(5) == 120

def test_factorial10():
    assert factorial(10) == 3628800