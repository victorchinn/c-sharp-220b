using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeworkAssignment05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public enum BoardMarker { Mark_X, Mark_O, Blank };
        public MainWindow()
        {
            InitializeComponent();
            ClearGameBoard();
        }

        private Dictionary<string, BoardMarker> _GameBoard = new Dictionary<string, BoardMarker>();

        private BoardMarker CurrentTurnMarker = BoardMarker.Mark_X;
        private bool GameOver = false;

        private void ClearGameBoard()
        {
            // CLEAR THE GAME BOARD BY INDICATING THE MARKER TYPE IS BLANK IN EACH CELL
            _GameBoard.Clear(); // POPULATE THE DICTIONARY
            _GameBoard.Add("00", BoardMarker.Blank);
            _GameBoard.Add("01", BoardMarker.Blank);
            _GameBoard.Add("02", BoardMarker.Blank);
            _GameBoard.Add("10", BoardMarker.Blank);
            _GameBoard.Add("11", BoardMarker.Blank);
            _GameBoard.Add("12", BoardMarker.Blank);
            _GameBoard.Add("20", BoardMarker.Blank);
            _GameBoard.Add("21", BoardMarker.Blank);
            _GameBoard.Add("22", BoardMarker.Blank);

            // VISUALLY...THE CONTENT OF EACH BUTTON HAS NULL (NOTHING VISIBLE) ... COULD ALSO DO SPACE CHAR
            foreach (var _EachChild in uxGrid.Children)
            {
                Button _EachButton = (Button)_EachChild;
                _EachButton.Content = "";
            }

            // FIRST TURN IS PLAYER X
            uxTurn.Text = "It is now Player X's turn.";
        }
        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            // START A NEW GAME BY CLEARING THE GAME BOARD AND RESET THE GAME OVER FLAG
            ClearGameBoard();
            GameOver = false;
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            // EXIT // ALL DONE ! 
            App.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // ONE OF THE CELL BUTTONS WAS CLICKED

            // SEE IF THE GAME IS ALREADY OVER ...
            if (GameOver == true)
            {
                uxTurn.Text = "Game is over.  Start a new game from the Menu.";
                return;
            }

            // FIND OUT WHICH BUTTON WAS CLICKED BY EVALUATING THE TAG FIELD
            Button _Sender = (Button)sender;
            string _ButtonID_Tag = _Sender.Tag.ToString();

            string _Index = _ButtonID_Tag.Remove(_ButtonID_Tag.IndexOf(','), 1);   // strip the , character then use result as index into dictionary

            if (_GameBoard[_Index] == BoardMarker.Blank)    // CLICKED ON A BLANK SPOT ON THE BOARD
            {
                // PUT THE MARKER OF THE CURRENT PLAYER ONTO THE BOARD
                if (CurrentTurnMarker == BoardMarker.Mark_X)
                {
                    _Sender.Content = "X";
                }
                else
                {
                    _Sender.Content = "O";
                }
                _GameBoard[_Index] = CurrentTurnMarker;

                // CHECK TO SEE IF THERE IS A WINNER 
                if (((CheckRow(CurrentTurnMarker) == true) || (CheckCol(CurrentTurnMarker) == true) || (CheckDiag(CurrentTurnMarker) == true)))
                {
                    uxTurn.Text += " WINNER !! WINNER !! ";
                    GameOver = true;
                    return;
                }

                // SEE IF THERE ARE ANY BLANKS LEFT ... IF NO BLANKS LEFT THEN GAME IS OVER AND THERE WAS NO WINNER
                if (CheckBlankSpace() == false)
                {
                    GameOver = true;
                    uxTurn.Text = "Game Over. Draw.";
                    return;
                }

                // MOVE FINISEHD ... NOW CHANGE TO THE NEXT PLAYER AND CYCLE
                if (CurrentTurnMarker == BoardMarker.Mark_X)
                {
                    CurrentTurnMarker = BoardMarker.Mark_O;
                    uxTurn.Text = "It is now Player O's turn.";
                }
                else
                {
                    CurrentTurnMarker = BoardMarker.Mark_X;
                    uxTurn.Text = "It is now Player X's turn.";
                }
            }
        }

        private bool CheckRow(BoardMarker _Marker)
        {
            // CHECK THE ROWS TO SEE IF THERE IS THREE IN A ROW FOR THE INDICATED MARKER TYPE
            for (int _Row = 0; _Row <= 2; _Row++)
            {
                string _Index = _Row.ToString();
                if ((_GameBoard[_Index + "0"] == _Marker) && (_GameBoard[_Index + "1"] == _Marker) && (_GameBoard[_Index + "2"] == _Marker))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckCol(BoardMarker _Marker)
        {
            // CHECK THE COLUMNS TO SEE IF THERE IS THREE IN A COL FOR THE INDICATED MARKER TYPE
            for (int _Col = 0; _Col <= 2; _Col++)
            {
                string _Index = _Col.ToString();
                if ((_GameBoard["0" + _Index] == _Marker) && (_GameBoard["1" + _Index] == _Marker) && (_GameBoard["2" + _Index] == _Marker))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckDiag(BoardMarker _Marker)
        {
            // CHECK THE DIAGONALS TO SEE IF THERE IS THREE IN A ROW FOR THE INDICATED MARKER TYPE
            if (((_GameBoard["00"] == _Marker) && (_GameBoard["11"] == _Marker) && (_GameBoard["22"] == _Marker)) ||
                ((_GameBoard["20"] == _Marker) && (_GameBoard["11"] == _Marker) && (_GameBoard["02"] == _Marker)))
            { return true; }
            else
            { return false; }
        }

        private bool CheckBlankSpace()
        {
            // CHECK TO SEE IF THERE ARE ANY AVAILABLE SPACES LEFT TO PUT EITHER AN X OR AN O
            bool _BlankFound = false;

            for (int _Row = 0; _Row <= 2; _Row++ )
            {
                for (int _Col = 0; _Col<= 2; _Col++)
                {
                    if (_GameBoard[_Row.ToString() + _Col.ToString()] == BoardMarker.Blank)
                    {
                        _BlankFound = true;
                    }
                }
            }

            return _BlankFound;
        }

    }
}
