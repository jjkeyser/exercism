def to_rna(dna_strand):
    rna = ""
    for dna in dna_strand.upper():
        if dna == 'G':
            rna += 'C'
        if dna == 'C':
            rna += 'G'
        if dna == 'T':
            rna += 'A'
        if dna == 'A':
            rna += 'U'
    return rna
