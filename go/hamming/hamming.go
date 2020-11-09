// Package hamming includes a function to calculate the Hamming distance of two strings
package hamming

import (
	"fmt"
)

// Distance takes two strings and returns their Hamming distance. Returns error if strings are of different lengths.
func Distance(a, b string) (int, error) {
	var hammingDistance int
	if len(a) != len(b) {
		return hammingDistance, fmt.Errorf("%s and %s are different lengths", a, b)
	}
	for i := 0; i < len(a); i++ {
		if a[i] != b[i] {
			hammingDistance++
		}
	}
	return hammingDistance, nil
}
