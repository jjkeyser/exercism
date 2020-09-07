def sum_of_multiples(limit, divisors):
    return sum({n for n in range(limit) for d in divisors if d > 0 and n % d == 0})
