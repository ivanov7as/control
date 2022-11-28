class TicTacToeBoard:
    def __init__(self):
        self.count = 0
        self.board = [['-', '-', '-'],['-', '-', '-'],['-', '-', '-']]
    
    def new_game(self):
        self.count = 0
        self.board = [['-', '-', '-'],['-', '-', '-'],['-', '-', '-']]
    
    def get_field(self):
        return self.board
 
    def check_field(self):
        if self.board[0][0] == 'X' and self.board[0][1] == 'X' and self.board[0][2] == 'X':
            return 'X'
        if self.board[0][0] == '0' and self.board[0][1] == '0' and self.board[0][2] == '0':
            return '0'
        if self.board[1][0] == 'X' and self.board[1][1] == 'X' and self.board[1][2] == 'X':
            return 'X'
        if self.board[1][0] == '0' and self.board[1][1] == '0' and self.board[1][2] == '0':
            return '0'
        if self.board[2][0] == 'X' and self.board[2][1] == 'X' and self.board[2][2] == 'X':
            return 'X'
        if self.board[2][0] == '0' and self.board[2][1] == '0' and self.board[2][2] == '0':
            return '0'
        if self.board[0][0] == 'X' and self.board[1][0] == 'X' and self.board[2][0] == 'X':
            return 'X'
        if self.board[0][0] == '0' and self.board[1][0] == '0' and self.board[2][0] == '0':
            return '0'
        if self.board[0][1] == 'X' and self.board[1][1] == 'X' and self.board[2][1] == 'X':
            return 'X'
        if self.board[0][1] == '0' and self.board[1][1] == '0' and self.board[2][1] == '0':
            return '0'
        if self.board[0][2] == 'X' and self.board[1][2] == 'X' and self.board[2][2] == 'X':
            return 'X'
        if self.board[0][2] == '0' and self.board[1][2] == '0' and self.board[2][2] == '0':
            return '0'
        if self.board[0][0] == 'X' and self.board[1][1] == 'X' and self.board[2][2] == 'X':
            return 'X'
        if self.board[0][0] == '0' and self.board[1][1] == '0' and self.board[2][2] == '0':
            return '0'
        if self.board[0][2] == 'X' and self.board[1][1] == 'X' and self.board[2][0] == 'X':
            return 'X'
        if self.board[0][2] == '0' and self.board[1][1] == '0' and self.board[2][0] == '0':
            return '0'
        if '-' not in self.board[0] and '-' not in self.board[1] and '-' not in self.board[2]:
            return 'D'
        else:
            return 'None'

    def make_move(self, row, col):
        win = self.check_field()
        if win == 'X':
            return 'Победил игрок X, игра завершена'
        if win == '0':
            return 'Победил игрок 0, игра завершена'
        if win == 'D':
            return 'Ничья, игра завершена'
        if win == 'None':
            print ('Делаем ход')
        if self.board[row-1][col-1] == '-':
            if self.count % 2 != 0:
                self.board[row-1][col-1] = 'X'
                self.count += 1
            else:
                self.board[row-1][col-1] = '0'
                self.count += 1
        if self.board[row-1][col-1] == 'X' or '0':
            return(f'Клетка {row} { col} занята')
