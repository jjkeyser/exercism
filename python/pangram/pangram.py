def is_pangram(sentence):
    alphabet = "abcdefghijklmnopqrstuvwxyz"
    letters = []
    for char in sentence.lower():
        if char not in letters and char in alphabet:
            letters.append(char)
    # i = 0
    # while i < len(sentence):
    #     if sentence[i].lower() not in letters and sentence[i].lower() in alphabet:
    #         letters.append(sentence[i].lower())
    #     i += 1
    return len(letters) == len(alphabet)
