using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
	class Program
	{
		static void Main(string[] args)
		{
			bool userPlay = true;

			while (userPlay)
			{
				bool boardInvalid = true;
				int x = 0;
				int y = 0;

				while (boardInvalid)
				{
					Console.Write("Pick number of columns between 3 and 6: ");
					string yInput = Console.ReadLine();

					Console.Write("Pick number of rows between 3 and 6: ");
					string xInput = Console.ReadLine();

					x = Convert.ToInt32(xInput);
					y = Convert.ToInt32(yInput);

					if (x >= 3 && x <= 6 && y >= 3 && y <= 6)
					{
						boardInvalid = false;
					}
					else
					{
						Console.WriteLine("Your response is invalid, please try again.");
					}
				}
				//Console.WriteLine("endloop");
				Console.Clear();

				int playerX = x / 2;
				int playerY = y / 2;

				bool stillMoving = true;

				while (stillMoving == true)
				{

					for (int row = -1; row <= x; row++)
					{
						for (int col = -1; col <= y; col++)
						{
							if (row == playerX && col == playerY)
							{
								Console.Write("P");
							}

							else if (col == -1 || row == -1 || col == y || row == x)
							{
								Console.Write("!");
							}

							else
							{
								Console.Write("*");
							}
						}

						Console.WriteLine();

					}
					Console.WriteLine("You current coordinates are " + playerX + ", " + playerY);
					if (playerX < 0 || playerX >= x || playerY < 0 || playerY >= y)
					{
						Console.WriteLine("Your player has fallen off the board.");
						break;

					}

					Console.WriteLine("Use arrow keys to move P");
					ConsoleKeyInfo keyInfo = Console.ReadKey();
					ConsoleKey s;
					s = keyInfo.Key;

					switch (s)
					{
						case ConsoleKey.UpArrow:
							playerX--;
							break;

						case ConsoleKey.DownArrow:
							playerX++;
							break;

						case ConsoleKey.LeftArrow:
							playerY--;
							break;

						case ConsoleKey.RightArrow:
							playerY++;
							break;
					}

					Console.Clear();
				}
				Console.WriteLine("Do you want to play again, Y or N?");
				string answer = Console.ReadLine();

				if (answer !="Y" && answer != "y")
				{
					userPlay = false;
					
				}

				
				
			}

			Console.WriteLine("Thank you for playing");






		}
	}
}
