def convert(number):
    sound = ""
    if number % 3 == 0 and number % 5 == 0 and number % 7 == 0:
        sound = "PlingPlangPlong"
    elif number % 3 == 0 and number % 5 == 0:
        sound = "PlingPlang"
    elif number % 3 == 0 and number % 7 == 0:
        sound = "PlingPlong"
    elif number % 3 == 0:
        sound = "Pling"
    elif number % 5 == 0 and number % 7 == 0:
        sound = "PlangPlong"
    elif number % 5 == 0:
        sound = "Plang"
    elif number % 7 == 0:
        sound = "Plong"
    else:
        sound = str(number)
    return sound