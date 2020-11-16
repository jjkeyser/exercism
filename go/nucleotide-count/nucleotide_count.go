package dna

import (
	"fmt"
)

// Histogram is a mapping from nucleotide to its count in given DNA.
type Histogram map[rune]int

// DNA is a list of nucleotides
type DNA string

// Counts generates a histogram of valid nucleotides in the given DNA.
// Returns an error if d contains an invalid nucleotide.
func (d DNA) Counts() (Histogram, error) {
	h := Histogram{'A': 0, 'C': 0, 'G': 0, 'T': 0}
	for _, nucleotide := range d {
		switch nucleotide {
		case
			'A',
			'C',
			'G',
			'T':
			h[nucleotide]++
		default:
			return h, fmt.Errorf("%q is not a valid nucleotide", nucleotide)
		}
	}
	return h, nil
}
