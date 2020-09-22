def largest(min_factor, max_factor):
    if min_factor > max_factor:
        raise ValueError("Min can't be greater than max")
    
    l = max(get_palindromic_products(min_factor, max_factor)) if len(get_palindromic_products(min_factor, max_factor)) > 0 else None
    return l, get_factors(l, min_factor, max_factor)


def smallest(min_factor, max_factor):
    if min_factor > max_factor:
        raise ValueError("Min can't be greater than max")

    s = min(get_palindromic_products(min_factor, max_factor)) if len(get_palindromic_products(min_factor, max_factor)) > 0 else None
    return s, get_factors(s, min_factor, max_factor)


def get_palindromic_products(start_range, end_range):
    products = list(
        {
            i * j
            for j in range(start_range, end_range + 1)
            for i in range(start_range, end_range + 1)
        }
    )
    return [p for p in products if str(p) == str(p)[::-1]]


def get_factors(n, start_range, end_range):
    if n == None:
        n = 0
    return [
        [i, int(n / i)]
        for i in range(start_range, end_range)
        if n % i == 0 and n / i >= start_range and n / i <= end_range
    ]
