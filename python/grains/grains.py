def square(number):
    if number < 1 or number > 64:
        raise ValueError("Number must be <= 64 and >= 1")
    return 2 ** (number - 1)


def total():
    return sum([square(i) for i in range(1, 65)])
