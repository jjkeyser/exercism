import re


def count_words(sentence):

    word_list = re.findall("[a-z0-9]+'*[0-9a-z]+|[0-9a-z]+", sentence.lower())
    word_count = {}

    for word in word_list:
        if word not in word_count.keys():
            word_count[word] = 1
        else:
            word_count[word] += 1
    return word_count
