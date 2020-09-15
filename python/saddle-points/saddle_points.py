def saddle_points(matrix):
    columns = list(zip(*matrix))
    saddle_points = []

    if len(matrix) == 0:
        return saddle_points

    if is_irregular_matrix(matrix):
        raise ValueError("Irregular matrix!")

    for i, row in enumerate(matrix):
        for j, num in enumerate(row):
            if num == max(row) and num == min(columns[j]):
                saddle_points.append({"row": i + 1, "column": j + 1})

    return saddle_points


def is_irregular_matrix(matrix):
    row_len = len(matrix[0])
    for i in range(0, len(matrix)):
        if len(matrix[i]) != row_len:
            return True
