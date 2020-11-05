// Package twofer contains a function that returns a string formatted depending on the argument string passed to it
package twofer

import "fmt"

// ShareWith should have a comment documenting it.
func ShareWith(name string) string {
	if name == "" {
		name = "you"
	}
	return fmt.Sprintf("One for %s, one for me.", name)
}
