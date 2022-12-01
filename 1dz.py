class MinStat:
    def __init__(self):
        self.value = []

    def add_number(self, number):
        self.value.append(number)

    def result(self):
        if self.value == []:
            return None
        else:
            return min(self.value)


class MaxStat:
    def __init__(self):
        self.value = []

    def add_number(self, number):
        self.value.append(number)

    def result(self):
        if self.value == []:
            return None
        else:
            return max(self.value)


class AverageStat:
    def __init__(self):
        self.value = []

    def add_number(self, number):
        self.value.append(number)

    def result(self):
        if self.value == []:
            return None
        else:
            return sum(self.value) / len(self.value)


class Table:

    def __init__(self, rows, cols):
        self.rows = rows
        self.cols = cols
        self.table = [[0 for i in range(cols)] for j in range(rows)]

    def get_value(self, row, col):
        if (0 <= row and row < self.rows) and (0 <= col and col < self.cols):
            return self.table[row][col]
        else:
            return None

    def set_value(self, row, col, value):
        self.table[row][col] = value

    def n_rows(self):
        return self.rows

    def n_cols(self):
        return self.cols

    def delete_row(self, row):
        self.table.pop(row)
        self.rows -= 1

    def delete_col(self, col):
        self.table.pop(col)
        self.cols -= 1

    def add_row(self, row):
        self.table.insert(row, [0 for k in range(self.rows)])
        self.rows += 1

    def add_col(self, col):
        for row in range(self.rows):
            self.table[row].insert(col, 0)
        self.cols += 1
