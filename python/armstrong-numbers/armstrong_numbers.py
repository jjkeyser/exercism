import math


def is_armstrong_number(number):
    number_str = str(number)
    number_length = len(number_str)
    digit_sum = 0
    for digit in number_str:
        digit_sum += math.pow(int(digit), number_length)

    return digit_sum == number
