def count_words(sentence):
    count = 0
    for word in sentence.split(" "):
        if word == word:
            count +=1 
            print(f"{word} : {count}")

count_words("word and me")