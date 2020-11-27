package grains

import (
	"errors"
)

const totalGrains = 1<<64 - 1

// Square returns 2 raised to the power of the input minus 1
// Returns an error if the input is < 1 or > 64
func Square(input int) (uint64, error) {
	if input < 1 || input > 64 {
		return 0, errors.New("Input must be between 1 and 64")
	}
	return 1 << (input - 1), nil
}

// Total returns the max value of a uint64
func Total() uint64 {
	return totalGrains
}
