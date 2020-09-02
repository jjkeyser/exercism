import re


class PhoneNumber:
    def __init__(self, number):
        self.number = self.clean_number(number)
        self.area_code = self.number[0:3]

    def clean_number(self, number):
        number = re.sub("[^0-9]", "", number)
        if (
            len(number) > 11
            or len(number) < 10
            or number[len(number) - 10] < "2"
            or number[len(number) - 7] < "2"
            or len(number) == 11 and number[0] != "1"
        ):
            raise ValueError("Invalid number")

        return number[1:] if len(number) == 11 else number

    def pretty(self):
        return f"({self.area_code}) {self.number[3:6]}-{self.number[6:]}"
