def steps(number):
    if number < 1:
        raise ValueError("Invalid number")

    collatz_number = number
    count = 0

    while collatz_number != 1:
        if collatz_number % 2 == 0:
            collatz_number = collatz_number / 2
        else:
            collatz_number = 3 * collatz_number + 1
        count += 1

    return count
