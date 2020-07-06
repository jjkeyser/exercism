def classify(number):
    aliquot_sum = 0
    i = 1
    if number == 0 or number < 0:
        raise ValueError("The number cannot be 0 or negative!")

    while i < number:
        if number % i == 0:
            aliquot_sum += i
        i += 1
    if aliquot_sum == number:
        return "perfect"
    elif aliquot_sum > number:
        return "abundant"
    else:
        return "deficient"
