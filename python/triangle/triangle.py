def equilateral(sides):
    return is_triangle(sides) and len(set(sides)) == 1


def isosceles(sides):
    return is_triangle(sides) and len(set(sides)) <= 2


def scalene(sides):
    return is_triangle(sides) and len(set(sides)) == 3


def is_triangle(sides):
    if (
        len(sides) != 3
        or 0 in sides
        or sides[0] + sides[1] < sides[2]
        or sides[1] + sides[2] < sides[0]
        or sides[2] + sides[0] < sides[1]
    ):
        return False
    return True
