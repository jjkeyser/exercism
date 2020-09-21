def equilateral(sides):
    if is_triangle(sides):
        return sides[0] == min(sides) and sides[0] == max(sides)
    return False


def isosceles(sides):
    if is_triangle(sides):
        return (
            sides[0] == sides[1] and sides[0] != sides[2]
            or sides[1] == sides[2] and sides[1] != sides[0]
            or sides[0] == sides[2] and sides[0] != sides[1]
            or equilateral(sides)
        )
    return False

def scalene(sides):
    if is_triangle(sides):
        return (
            sides[0] != sides[1] and sides[0] != sides[2]
        )
    return False


def is_triangle(sides):
    if len(sides) != 3:
        return False
    for side in sides:
        if side <= 0:
            return False
    if (
        sides[0] + sides[1] < sides[2]
        or sides[1] + sides[2] < sides[0]
        or sides[2] + sides[0] < sides[1]
    ):
        return False
    return True
