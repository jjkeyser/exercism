def classify(number):

    if number <= 0:
        raise ValueError("The number cannot be 0 or negative!")

    factors = [i for i in range(1, number - 1) if number % i == 0]

    if sum(factors) == number:
        return "perfect"
    elif sum(factors) > number:
        return "abundant"
    else:
        return "deficient"
