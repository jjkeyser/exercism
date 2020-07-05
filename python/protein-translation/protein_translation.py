def proteins(strand):
    proteins = {
        "Methionine": ["AUG"],
        "Phenylalanine": ["UUU", "UUC"],
        "Leucine": ["UUA", "UUG"],
        "Serine": ["UCU", "UCC", "UCA", "UCG"],
        "Tyrosine": ["UAU", "UAC"],
        "Cysteine": ["UGU", "UGC"],
        "Tryptophan": ["UGG"],
    }

    n = 3
    rna_list = [strand[i : i + n] for i in range(0, len(strand), n)]
    protein_list = []

    for rna in rna_list:
        if rna == "UAA" or rna == "UAG" or rna == "UGA":
            break
        else:
            for key, values in proteins.items():
                for value in values:
                    if rna == value:
                        protein_list.append(key)
    return protein_list
