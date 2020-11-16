// Package bob contains functions to determine the response given a string
package bob

import (
	"strings"
	"unicode"
)

const (
	defaultResponse         = "Whatever."
	shoutResponse           = "Whoa, chill out!"
	questionResponse        = "Sure."
	shoutedQuestionResponse = "Calm down, I know what I'm doing!"
	emptyStatementResponse  = "Fine. Be that way!"
)

// Hey takes a string and returns a response based on the formatting of the string
func Hey(remark string) string {
	trimmedRemark := strings.TrimSpace(remark)
	response := defaultResponse
	if trimmedRemark == "" {
		response = emptyStatementResponse
	} else if IsQuestion(trimmedRemark) {
		if IsShouting(trimmedRemark) && HasLetters(trimmedRemark) {
			response = shoutedQuestionResponse
		} else {
			response = questionResponse
		}
	} else if IsShouting(trimmedRemark) && HasLetters(trimmedRemark) {
		response = shoutResponse
	}
	return response
}

// IsShouting takes a string and determines if it is all caps
func IsShouting(s string) bool {
	for _, r := range s {
		if unicode.IsLetter(r) && unicode.IsLower(r) {
			return false
		}
	}
	return true
}

// IsQuestion takes a string and determines if the last character is a question mark
func IsQuestion(s string) bool {
	return strings.HasSuffix(s, "?")
}

// HasLetters determines if a string contains any letters
func HasLetters(s string) bool {
	for _, r := range s {
		if unicode.IsLetter(r) {
			return true
		}
	}
	return false
}
