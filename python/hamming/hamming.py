def distance(strand_a, strand_b):

    char_diff = []
    
    if len(strand_a) != len(strand_b):
        raise ValueError("The strands must be the same length")
    else:
        for i in range(0, len(strand_a)):
                if strand_a[i] != strand_b[i]:
                    char_diff.append(strand_b[i])
                i += 1
    
    print(len(char_diff))
    return len(char_diff)


distance("AATG", "AAAB")
