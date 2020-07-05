def proteins(strand):
    proteins = {
        "Methionine": ["AUG"],
        "Phenylalanine": ["UUU", "UUC"],
        "Leucine": ["UUA", "UUG"],
        "Serine": ["UCU", "UCC", "UCA", "UCG"],
        "Tyrosine": ["UAU", "UAC"],
        "Cysteine": ["UGU", "UGC"],
        "Tryptophan": ["UGG"],
        "STOP": ["UAA", "UAG", "UGA"],
    }
    protein_list = []
    for key, values in proteins.items():
        for value in values:
            if strand == 'UAA' or strand == 'UAG' or strand == 'UGA':
                continue
            elif strand == value:
                protein_list.append(key)
    # print(protein_list)
    return protein_list


proteins("UAA")
