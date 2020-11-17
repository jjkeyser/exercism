/*Package collatzconjecture handles the 3x+1 problem which can be summarized as follows:

Take any positive integer n. If n is even, divide n by 2 to get n / 2. If n is
odd, multiply n by 3 and add 1 to get 3n + 1. Repeat the process indefinitely.
The conjecture states that no matter which number you start with, you will
always reach 1 eventually.

*/
package collatzconjecture

import (
	"fmt"
)

// CollatzConjecture takes a number and runs it through the 3n+1 problem.
// Returns an error if the number is less than one.
func CollatzConjecture(number int) (int, error) {
	if number < 1 {
		return 0, fmt.Errorf("%d is not greater than one", number)
	}
	stepCount := 0

	for {
		if number == 1 {
			break
		}
		if number%2 == 0 {
			number /= 2
		} else {
			number = 3*number + 1
		}
		stepCount++
	}
	return stepCount, nil
}
