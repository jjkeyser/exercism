import math


def is_armstrong_number(number):
    return number == sum(
        [math.pow(int(digit), len(str(number))) for digit in str(number)]
    )
