import pytest
import fib


def test_factorial1():
    assert fib.fibonacci(1) == 1


def test_factorial5():
    assert fib.fibonacci(8) == 21


def test_factorial10():
    assert fib.fibonacci(10) == 55