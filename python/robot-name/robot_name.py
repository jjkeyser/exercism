import random
import string


class Robot:
    def __init__(self):
        self.name = self.set_name()

    def set_name(self):
        return "".join(
            random.choices(string.ascii_uppercase, k=2)
            + random.choices(string.digits, k=3)
        )

    def reset(self):
        while self.name == self.set_name():
            self.name = self.set_name()
