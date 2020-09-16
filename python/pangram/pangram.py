def is_pangram(sentence):
    alphabet = "abcdefghijklmnopqrstuvwxyz"
    letters = []
    for char in sentence.lower():
        if char not in letters and char in alphabet:
            letters.append(char)
    return len(letters) == len(alphabet)
