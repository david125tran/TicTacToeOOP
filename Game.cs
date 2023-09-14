using System;

public class Game
{
    // ------------------------ Public Member Variables ------------------------
    public List<char> _field = new List<char>();

    // ------------------------ Public Properties ------------------------


    // ------------------------ Default Constructor ------------------------
    /// <summary>This method intializes the TicTacToe board when the Game() class is called.</summary>
    public Game()
    {
        _field.Add('1');
        _field.Add('2');
        _field.Add('3');
        _field.Add('4');
        _field.Add('5');
        _field.Add('6');
        _field.Add('7');
        _field.Add('8');
        _field.Add('9');

    }

    // ------------------------ Member Methods ------------------------
    /// <summary>This method displays the TicTacToe board.</summary>
    public void ShowField()
    {
        Console.WriteLine("\n");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" {0} | {1} | {2} ", _field[0], _field[1], _field[2]);
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" {0} | {1} | {2} ", _field[3], _field[4], _field[5]);
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" {0} | {1} | {2} ", _field[6], _field[7], _field[8]);
        Console.WriteLine("   |   |   ");
    }

    /// <summary>This method retrieves what is in a square.</summary>
    /// <returns>what is in the square of the TicTacToe board.</returns>
    public char GetSquare(int choice)
    {
        return _field[choice];
    }

    /// <summary>This method updates the TicTacToe board with the player's mark</summary>
    public void UpdateSquare(int choice, int player)
    {
        if (player == 1)
        {
            _field[choice - 1] = 'X';
        }
        else
        {
            _field[choice - 1] = 'O';
        }
    }

    /// <summary>This method checks for a winner or draw.</summary>
    /// <returns>true for if there is a win or draw.  false for if there is not a win or draw</returns>
    public bool CheckForWinner()
    {
        // ----------------------- Check for a winner in rows -----------------------
        if (_field[0] == _field[1] && _field[0] == _field[2])
        {
            Console.WriteLine("\n\nPlayer {0} wins!", _field[0]);
            return true;
        }
        else if (_field[3] == _field[4] && _field[3] == _field[5])
        {
            Console.WriteLine("\n\nPlayer {0} wins!", _field[3]);
            return true;
        }
        else if (_field[6] == _field[7] && _field[6] == _field[8])
        {
            Console.WriteLine("\n\nPlayer {0} wins!", _field[6]);
            return true;
        }

        // ----------------------- Check for a winner in columns -----------------------
        else if (_field[0] == _field[3] && _field[0] == _field[6])
        {
            Console.WriteLine("\n\nPlayer {0} wins!", _field[0]);
            return true;
        }
        else if (_field[1] == _field[4] && _field[1] == _field[7])
        {
            Console.WriteLine("\n\nPlayer {0} wins!", _field[1]);
            return true;
        }
        else if (_field[2] == _field[5] && _field[2] == _field[8])
        {
            Console.WriteLine("\n\nPlayer {0} wins!", _field[2]);
            return true;
        }

        // ----------------------- Check for a winner in diagonals -----------------------
        else if (_field[0] == _field[4] && _field[0] == _field[8])
        {
            Console.WriteLine("\n\nPlayer {0} wins!", _field[0]);
            return true;
        }
        else if (_field[2] == _field[4] && _field[2] == _field[6])
        {
            Console.WriteLine("\n\nPlayer {0} wins!", _field[2]);
            return true;
        }

        // ----------------------- Check if field is full -----------------------
        else if (_field[0] != '1' && _field[1] != '2' && _field[2] != '3' && _field[3] != '4' && _field[4] != '5' && _field[5] != '6' && _field[6] != '7' && _field[7] != '8' && _field[8] != '9')
        {
            Console.WriteLine("\n\nThere is not winner!");
            return true;
        }
        else
        {
            return false;
        }

    }

    /// <summary>This method resets the TicTacToe field to a new game.</summary>    
    public void ResetField()
    {
        _field[0] = '1';
        _field[1] = '2';
        _field[2] = '3';
        _field[3] = '4';
        _field[4] = '5';
        _field[5] = '6';
        _field[6] = '7';
        _field[7] = '8';
        _field[8] = '9';

    }

}
