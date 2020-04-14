import re


def count_words(sentence):

    word_list = re.findall("[a-z0-9]+'*[0-9a-z]+|[0-9a-z]+", sentence.lower())
    print(word_list)
    word_count = {}

    count = 0
    i = 0
    while i < len(word_list):
        count = 0
        for word in word_list:
            if word == word_list[i]:
                count += 1
                word_count[word] = count
        i += 1
    print(word_count)
    return word_count


count_words("1: one two's")
