def distance(strand_a, strand_b):

    distance_count = 0

    if len(strand_a) != len(strand_b):
        raise ValueError("The strands must be the same length")
    else:
        for i in range(0, len(strand_a)):
            if strand_a[i] != strand_b[i]:
                distance_count += 1
            i += 1
    
    return distance_count
