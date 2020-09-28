import re

def count_words(sentence):

    pattern = "[a-z0-9]+'*[0-9a-z]+|[0-9a-z]+"
    word_list = re.findall(pattern, sentence.lower())
    word_count = {}

    for word in word_list:
        if word not in word_count.keys():
            word_count[word] = 1
        else:
            word_count[word] += 1

    return word_count
