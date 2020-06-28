def find_anagrams(word, candidates):
    matches = []
    letter_list = sorted([letter for letter in word.lower()])
    candidate_list = []
    for candidate in candidates:
        candidate_list.append(sorted([letter for letter in candidate.lower()]))
    i = 0
    for i in range(0, len(candidate_list)):
        if candidate_list[i] == letter_list and candidates[i].lower() != word.lower():
            matches.append(candidates[i])
    return(matches)
