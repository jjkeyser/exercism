import re
from collections import Counter


def count_words(sentence):

    pattern = "[a-z0-9]+'*[0-9a-z]+|[0-9a-z]+"
    return Counter(re.findall(pattern, sentence.lower()))
