def is_isogram(string):
    string_list = []
    for letter in string.lower():
        if letter in string_list:
            return False
        elif letter.isalpha():
            string_list.append(letter)
    return True

