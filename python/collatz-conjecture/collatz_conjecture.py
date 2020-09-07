def steps(number):
    if number < 1:
        raise ValueError("Invalid number")

    count = 0

    while number != 1:
        number = 3*number+1 if number%2 else number//2
        count += 1

    return count
