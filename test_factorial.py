import pytest
import main


def test_factorial1():
    assert main.factorial(1) == 1


def test_factorial5():
    assert main.factorial(5) == 120


def test_factorial10():
    assert main.factorial(10) == 3628800