DAY = [
    "first",
    "second",
    "third",
    "fourth",
    "fifth",
    "sixth",
    "seventh",
    "eighth",
    "ninth",
    "tenth",
    "eleventh",
    "twelfth",
]

LYRICS = [
    "twelve Drummers Drumming",
    "eleven Pipers Piping",
    "ten Lords-a-Leaping",
    "nine Ladies Dancing",
    "eight Maids-a-Milking",
    "seven Swans-a-Swimming",
    "six Geese-a-Laying",
    "five Gold Rings",
    "four Calling Birds",
    "three French Hens",
    "two Turtle Doves",
    "a Partridge in a Pear Tree",
]


def recite(start_verse, end_verse):
    return [get_verse(number) for number in range(start_verse, end_verse + 1)]


def get_verse(number):
    opening_phrase = (
        f"On the {DAY[number - 1]} day of Christmas my true love gave to me:"
    )

    return (
        f"{opening_phrase} {LYRICS[-1]}."
        if number == 1
        else f"{opening_phrase} {', '.join(LYRICS[-number: -1])}, and {LYRICS[-1]}."
    )
