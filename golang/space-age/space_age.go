// Package space includes a function to return an age on a given planet given seconds old on earth
package space

type Planet string

var planetConversion = map[Planet]float64{
	"Mercury": 0.2408467,
	"Venus":   0.61519726,
	"Earth":   1,
	"Mars":    1.8808158,
	"Jupiter": 11.862615,
	"Saturn":  29.447498,
	"Uranus":  84.016846,
	"Neptune": 164.79132,
}

// EARTHYEARINSECONDS represents the number of seconds in one Earth year according to the Gregorian calendar
const EARTHYEARINSECONDS float64 = 365.2425 * 24.0 * 60 * 60

// Age takes an age in seconds on earth and a planet to determine the age on and returns the age in Earth years on that planet
func Age(seconds float64, planet Planet) float64 {
	earthAge := seconds / EARTHYEARINSECONDS
	return earthAge / planetConversion[planet]
}
