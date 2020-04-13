def count_words(sentence):
    count = 0
    word_list = []
    for word in sentence.split():
        word_list.append(word)

    word_count = {}

    i = 0
    while i < len(word_list):
        count = 0
        for word in word_list:
            if word == word_list[i]:
                count += 1
                word_count[word] = count
        i += 1
        return word_count


count_words("one of each")
