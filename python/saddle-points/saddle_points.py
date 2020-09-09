def saddle_points(matrix):
    for i in range(0, len(matrix)):
        row_len = len(matrix[0])
        if len(matrix[i]) != row_len:
            raise ValueError("Irregular matrix!")
