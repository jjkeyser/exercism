package diffsquares

// SquareOfSum returns the square of the sum of natural numbers from 1
// up to a given number
func SquareOfSum(n int) int {
	sum := n * (n + 1) / 2
	return sum * sum
}

// SumOfSquares returns the sum of the squares of natural numbers from 1
// up to the give number
func SumOfSquares(n int) int {
	return (n * (n + 1) * (2*n + 1)) / 6
}

// Difference returns the difference between the square of the sum of a number
// and the sum of the squares of a number
func Difference(n int) int {
	return SquareOfSum(n) - SumOfSquares(n)
}
