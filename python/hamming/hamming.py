def distance(strand_a, strand_b):

    char_diff = []
   
    for i in range(0, len(strand_a)):
            if strand_a[i] != strand_b[i]:
                char_diff.append(strand_b[i])
            i += 1
    
    print(len(char_diff))
    return len(char_diff)


distance("AATG", "AAA")
