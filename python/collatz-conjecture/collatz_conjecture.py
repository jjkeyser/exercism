def steps(number):
    if number < 1:
        raise ValueError("Invalid number")

    steps = 0

    while number != 1:
        number = 3*number+1 if number%2 else number//2
        steps += 1

    return steps
