using System;

public class TicTacTone
{
	static char[] board;
	static char player = ' ';

	public static void main(String[] args)
	{
		board = new char[10];
		populateBoard();
		char computer = ' ';
		player = selectXorO();
		if (player == 'X')
		{
			computer = 'O';
		}
		else
		{
			computer = 'X';
		}
		Console.WriteLine(player + " is player " + computer + " is computer");
		showBoard();
		makeaMove();
	}

	static void populateBoard()
	{
		for (int i = 1; i < 10; i++)
		{
			board[i] = ' ';
		}

	}

	public static char selectXorO()
	{
		Console.WriteLine("Select X or O");
		char player = Console.ReadLine()[0];
		Console.Write(player);
		return player;
	}
	public static void showBoard()
	{
		for (int i = 1; i < board.length; i = i + 3)
		{
			Console.WriteLine("| " + board[i] + " | " + board[i + 1] + " | " + board[i + 2] + " |");
		}

	}
	public static void makeaMove()
	{
		while (true)
		{
			Console.WriteLine("Enter a slot to place " + player);
			int slot = Convert.ToInt32(Console.ReadLine());
			if (board[slot] == ' ')
			{
				board[slot] = player;
				break;
			}
			else
			{
				Console.WriteLine("Invalid choice,Enter again");
			}
		}
		showBoard();
	}



}