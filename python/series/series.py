def slices(series, length):
    if length > len(series):
        raise ValueError("The slice length can't exceed the series")
    elif length <=0:
        raise ValueError("The slice length must be greater than 0")
    elif series is "":
        raise ValueError("The series cannot be empty")
    
    return [series[i : length + i] for i in range(0, len(series)-length+1)]