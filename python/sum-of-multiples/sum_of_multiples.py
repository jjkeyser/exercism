def sum_of_multiples(limit, divisors):
    multiples = set()
    for num in range(1, limit):
        for d in divisors:
            if d != 0 and num % d == 0:
                multiples.add(num)
    return sum(multiples)
