import random
import string


class Robot:
    def __init__(self):
        self.name = self.set_name()

    def set_name(self):
        prefix = "".join(random.choices(string.ascii_uppercase, k=2))
        number = random.randint(100, 999)

        return prefix + str(number)

    def reset(self):
        while self.name == self.set_name():
            self.name = self.set_name()
