package scrabble

import (
	"strings"
)

func letterValue(r rune) int {
	switch r {
	case 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't':
		return 1
	case 'd', 'g':
		return 2
	case 'b', 'c', 'm', 'p':
		return 3
	case 'f', 'h', 'v', 'w', 'y':
		return 4
	case 'k':
		return 5
	case 'j', 'x':
		return 8
	case 'q', 'z':
		return 10
	default:
		return 0
	}
}

// Score returns the scrabble score of a word
func Score(word string) int {
	score := 0
	for _, letter := range strings.ToLower(word) {
		score += letterValue(letter)
	}
	return score
}
