package luhn

import (
	"strings"
	"unicode"
)

func Valid(number string) bool {

	number = strings.ReplaceAll(number, " ", "")

	if containsInvalidChars(number) || len(number) <= 1 {
		return false
	}

	everySecond := len(number)%2 == 0
	sum := 0

	for _, d := range number {
		d = d - '0'
		if !everySecond {
			sum += int(d)
		} else {
			d *= 2
			if d > 9 {
				d -= 9
			}
			sum += int(d)
		}
		everySecond = !everySecond
	}

	return sum%10 == 0
}

func containsInvalidChars(s string) bool {
	for _, char := range s {
		if !unicode.IsDigit(char) {
			return true
		}
	}
	return false
}
