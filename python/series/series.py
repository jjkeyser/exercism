def slices(series, length):
    if length > len(series) or length <= 0 or series == "":
        raise ValueError("Invalid arguments")

    return [series[i : length + i] for i in range(0, len(series) - length + 1)]
