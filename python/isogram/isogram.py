def is_isogram(string):
    string_list = [letter for letter in string.lower() if letter.isalpha()]

    return len(string_list) == len(set(string_list))
