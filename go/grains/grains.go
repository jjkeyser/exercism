package grains

import (
	"errors"
	"math"
)

func Square(input int) (uint64, error) {
	var err error
	if input < 1 || input > 64 {
		err = errors.New("Input must be between 1 and 64")
	}
	return uint64(math.Pow(2, float64(input)-1)), err
}

func Total() uint64 {
	var totalGrains uint64
	for i := 1; i <= 64; i++ {
		square, _ := Square(i)
		totalGrains += square
	}
	return totalGrains
}
