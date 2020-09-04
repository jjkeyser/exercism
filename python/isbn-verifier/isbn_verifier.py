from re import sub


def is_valid(isbn):
    number_str = sub("[^0-9]", "", isbn[0:-1])
    check_digit = 0
 
    if not isbn_length_is_valid(number_str):
        return False

    if not get_isbn_check_digit(isbn[-1]):
        return False
    else:
        check_digit = get_isbn_check_digit(isbn[-1])

    print(number_str)
    print(check_digit)

    check_sum = get_isbn_check_sum(number_str)

    return (check_sum + check_digit) % 11 == 0


def isbn_length_is_valid(number):
    return len(number) == 9


def get_isbn_check_digit(char):
    if char.lower() == 'x':
        char = 10
    elif not char.isdigit():
        return False
    else:
        char = int(char)
    return char

def get_isbn_check_sum(number_str):
    check_sum = 0
    i = 10
    for num in number_str:
        check_sum += i * int(num)
        print(check_sum)
        i -= 1
    return check_sum


is_valid("3-598-21508-A")
