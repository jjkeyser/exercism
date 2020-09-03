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
    "twelve Drummers Drumming, ",
    "eleven Pipers Piping, ",
    "ten Lords-a-Leaping, ",
    "nine Ladies Dancing, ",
    "eight Maids-a-Milking, ",
    "seven Swans-a-Swimming, ",
    "six Geese-a-Laying, ",
    "five Gold Rings, ",
    "four Calling Birds, ",
    "three French Hens, ",
    "two Turtle Doves, and ",
    "a Partridge in a Pear Tree.",
]


def recite(start_verse, end_verse):
    return [get_verse(number) for number in range(start_verse, end_verse + 1)]


def get_verse(number):
    return f'On the {DAY[number - 1]} day of Christmas my true love gave to me: {"".join(LYRICS[-number:])}'
