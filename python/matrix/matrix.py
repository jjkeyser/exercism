class Matrix:
    def __init__(self, matrix_string):
        self._matrix_string = matrix_string

    def row(self, index):
        matrix_row = self._matrix_string.splitlines()
        matrix_row_list = []
        for num in matrix_row[index - 1].split():
            num = int(num)
            matrix_row_list.append(num)
        return matrix_row_list

    def column(self, index):
        pass


x = Matrix("1 2 3\n4 5 6")

print(x.row(1))
