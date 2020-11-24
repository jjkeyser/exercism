package luhn

import (
	"strconv"
	"strings"
	"unicode"
)

func Valid(number string) bool {

	number = strings.ReplaceAll(number, " ", "")

	if containsInvalidChars(number) || len(number) <= 1 {
		return false
	}

	number = doubleEverySecondDigit(number)

	if sumAllDigits(number)%10 != 0 {
		return false
	}

	return true
}

func containsInvalidChars(s string) bool {
	for _, char := range s {
		if !unicode.IsDigit(char) {
			return true
		}
	}
	return false
}

func doubleEverySecondDigit(s string) string {
	split := strings.Split(s, "")

	for i := len(split) - 2; i >= 0; i -= 2 {
		digit, _ := strconv.Atoi(split[i])
		digit *= 2
		if digit > 9 {
			digit -= 9
		}
		split[i] = strconv.Itoa(digit)
	}
	return strings.Join(split, "")
}

func sumAllDigits(s string) int {
	split := strings.Split(s, "")
	sum := 0

	for _, digit := range split {
		digit, _ := strconv.Atoi(digit)
		sum += digit
	}
	return sum
}
