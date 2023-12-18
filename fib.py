def fibonacci(n):
    if n <= 0:
        return "Введите положительное число"
    elif n == 1:
        return 0
    elif n == 2:
        return 1
    else:
        fib_1 = 0  # первое число Фибоначчи
        fib_2 = 1  # второе число Фибоначчи
        for _ in range(3, n+1):
            fib_1, fib_2 = fib_2, fib_1 + fib_2
        return fib_2

def main():
    n = int(input("Введите число n: "))
    result = fibonacci(n)
    print(f"Число Фибоначчи под номером {n}: {result}")

if __name__ == "__main__":
    main()
