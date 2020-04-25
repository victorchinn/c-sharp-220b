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

            foreach (var _EachChild in uxGrid.Children)
            {
                Button _EachButton = (Button)_EachChild;
                _EachButton.Content = "";
            }

            uxTurn.Text = "It is now Player X's turn.";

        }
        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            ClearGameBoard();
            GameOver = false;

        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (GameOver == true)
            {
                uxTurn.Text = "Game is over.  Start a new game from the Menu.";
                return;
            }
            Button _Sender = (Button)sender;
            string _ButtonID_Tag = _Sender.Tag.ToString();

            string _Index = _ButtonID_Tag.Remove(_ButtonID_Tag.IndexOf(','), 1);   // strip the , character then use result as index into dictionary

            if (_GameBoard[_Index] == BoardMarker.Blank)
            {
                if (CurrentTurnMarker == BoardMarker.Mark_X)
                {
                    _Sender.Content = "X";
                }
                else
                {
                    _Sender.Content = "O";
                }
                _GameBoard[_Index] = CurrentTurnMarker;
            }

            // now check to see if there is a winner
            if (((CheckRow(CurrentTurnMarker) == true) || (CheckCol(CurrentTurnMarker) == true) || (CheckDiag(CurrentTurnMarker) == true)))
            {
                uxTurn.Text += " WINNER !! WINNER !! ";
                GameOver = true;
                return;
            }

            // SEE IF THERE ARE ANY BLANKS LEFT ... IF NO BLANKS THEN GAME IS OVER
            if (CheckBlankSpace() == false)
            {
                GameOver = true;
                uxTurn.Text = "Game Over. Draw.";
                return;
            }

            // CHANGE TO THE NEXT PLAYER
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

        private bool CheckRow(BoardMarker _Marker)
        {
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
            if (((_GameBoard["00"] == _Marker) && (_GameBoard["11"] == _Marker) && (_GameBoard["22"] == _Marker)) ||
                ((_GameBoard["20"] == _Marker) && (_GameBoard["11"] == _Marker) && (_GameBoard["02"] == _Marker)))
            { return true; }
            else
            { return false; }
        }

        private bool CheckBlankSpace()
        {
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
