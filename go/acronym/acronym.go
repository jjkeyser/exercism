//Package acronym has a function that creates an acronym from a string
package acronym

import (
	"strings"
)

// Abbreviate takes a string and returns an acronym of that string
// The acronym is made up of the first letter of each word in the string
func Abbreviate(s string) string {
	var acronym strings.Builder
	s = strings.NewReplacer("-", " ", "_", "").Replace(s)
	words := strings.Fields(s)
	for _, word := range words {
		acronym.WriteByte(word[0])
	}
	return strings.ToUpper(acronym.String())
}
