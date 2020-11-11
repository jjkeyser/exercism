package raindrops

import "strconv"

// Convert takes a number and converts it to a string of raindrops
func Convert(input int) string {
	result := ""
	if input%3 == 0 {
		result += "Pling"
	}
	if input%5 == 0 {
		result += "Plang"
	}
	if input%7 == 0 {
		result += "Plong"
	}
	if result == "" {
		result = strconv.Itoa(input)
	}
	return result
}
