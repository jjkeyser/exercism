import re
from collections import Counter


def count_words(sentence):

    pattern = "[a-z0-9]+'*[0-9a-z]+|[0-9a-z]+"
    word_list = re.findall(pattern, sentence.lower())
    word_count = Counter()

    for word in word_list:
        word_count[word] += 1

    return word_count
