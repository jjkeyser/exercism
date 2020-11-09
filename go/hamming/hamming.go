package hamming

import "errors"

func Distance(a, b string) (int, error) {
	var distance int
	if len(a) != len(b) {
		return distance, errors.New("Strings are different lengths, can't determine Hamming distance")
	}
	for i := 0; i < len(a); i++ {
		if a[i] != b[i] {
			distance++
		}
	}
	return distance, nil
}
