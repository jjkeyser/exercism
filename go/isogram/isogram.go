package isogram

import (
	"strings"
	"unicode"
)

// IsIsogram returns whether a string is an isogram
func IsIsogram(word string) bool {
	w := strings.ToLower(word)
	for _, letter := range w {
		if unicode.IsLetter(letter) && strings.Count(w, string(letter)) > 1 {
			return false
		}
	}
	return true
}
