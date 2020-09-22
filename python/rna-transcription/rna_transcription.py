def to_rna(dna_strand):
    nucleotide_mappings = {
        'G' : 'C',
        'C' : 'G',
        'T' : 'A',
        'A' : 'U'
    }

    return "".join([nucleotide_mappings[dna] for dna in dna_strand])
