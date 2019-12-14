def latest(scores):
    return scores[-1]

def personal_best(scores):
    return max(scores)

def personal_top_three(scores):
    #scores_list= scores
    #scores_list.sort(reverse = True)
    #print(sorted(scores, reverse= True)[:3])
    return sorted(scores, reverse= True)[:3]

personal_top_three([1,13])