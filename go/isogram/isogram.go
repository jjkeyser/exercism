package isogram

import (
	"strings"
	"unicode"
)

// IsIsogram returns whether a string is an isogram
func IsIsogram(word string) bool {
	lowerWord := strings.ToLower(word)
	for _, letter := range lowerWord {
		if unicode.IsLetter(letter) && strings.Count(lowerWord, string(letter)) > 1 {
			return false
		}
	}
	return true
}
