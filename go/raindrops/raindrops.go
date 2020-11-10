package raindrops

import "strconv"

func Convert(input int) (result string) {
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
