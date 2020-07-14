def recite(start_verse, end_verse):
    day = [
        "first", 
        "second", 
        "third", 
        "fourth",
        "fifth",
        "sixth",
        "seventh",
        "eigth",
        "ninth",
        "tenth",
        "eleventh",
        "twelfth"]  
    opening_phrase = f"On the {day[end_verse - 1]} day of Christmas my true love gave to me: "
    filler = "and "
    lyrics = [
        "a Partridge in a Pear Tree.", 
        "two Turtle Doves, ", 
        "three French Hens, ",
        "four Calling Birds, ", 
        "five Gold Rings, ", 
        "six Geese-a-Laying, ",
        "seven Swans-a-Swimming, ",
        "eight Maids-a-Milking, ",
        "nine Ladies Dancing, ",
        "ten Lords-a-Leaping, ",
        "eleven Pipers Piping, ",
        "twelve Drummers Drumming, "]

    if start_verse <= 1:
        return [opening_phrase + str(lyrics[end_verse - 1])]
