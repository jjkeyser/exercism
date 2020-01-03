def is_pangram(sentence):
    alphabet = "abcdefghijklmnopqrstuvwxyz"
    letters = []
    i = 0
    while i < len(sentence):
        if sentence[i].lower() not in letters and sentence[i].lower() \
          in alphabet:
            letters.append(sentence[i].lower())
        i += 1
    if len(letters) == len(alphabet):
        return True
    else:
        return False
