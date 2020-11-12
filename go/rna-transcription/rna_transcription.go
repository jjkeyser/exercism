package strand

import "strings"

func ToRNA(dna string) string {
	rna := strings.NewReplacer(
		"G", "C",
		"C", "G",
		"T", "A",
		"A", "U",
	)
	return rna.Replace(dna)
}
