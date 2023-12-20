string[] availableSigns = { "rock", "paper", "scissors" };

int firstPlayerPoints = 0;
int secondPlayerPoints = 0;
Boolean continuePlayingBool = true;

while (continuePlayingBool)
{
	Console.WriteLine("How many rounds?:");
	string? numberOfRoundsTxt = Console.ReadLine()?.ToLower().Trim();
	int numberOfRounds = Convert.ToInt32(numberOfRoundsTxt);
	Console.WriteLine("Number of rounds: " + numberOfRounds);
	for (int i = 0; i < numberOfRounds; i++)
	{
		Console.WriteLine("Player 1, provide sign:");
		string? firstSign = Console.ReadLine()?.ToLower().Trim();

		while (!availableSigns.Contains(firstSign) && firstSign != "quit")
		{
			Console.WriteLine("wrong sign");
			firstSign = Console.ReadLine()?.ToLower().Trim();
		}

		if (firstSign == "quit")
		{
			break;
		}

		Console.WriteLine("Player 2, provide sign:");
		string? secondSign = Console.ReadLine()?.ToLower().Trim();

		while (!availableSigns.Contains(secondSign) && secondSign != "quit")
		{
			Console.WriteLine("wrong sign");
			secondSign = Console.ReadLine()?.ToLower().Trim();
		}

		if (secondSign == "quit")
		{
			break;
		}

		int secondSignIndex = Array.IndexOf(availableSigns, secondSign);
		int secondSignWinningIndex = (secondSignIndex + 1) % availableSigns.Length;
		string secondSignWinningSign = availableSigns[secondSignWinningIndex];

		if (firstSign == secondSign)
		{
			Console.WriteLine("draw");
		}
		// else if ((firstSign == "paper" && secondSign == "rock") || // to change - use availableSigns and moduol
		// 	(firstSign == "rock" && secondSign == "scissors") ||
		// 	(firstSign == "scissors" && secondSign == "paper"))
		else if (firstSign == secondSignWinningSign)
		{
			Console.WriteLine("Player 1 won");
			firstPlayerPoints++;
		}
		else
		{
			Console.WriteLine("Player 2 won");
			secondPlayerPoints++;

		}

	}
	Console.WriteLine("Score: P1:" + firstPlayerPoints + " P2:" + secondPlayerPoints);

	Console.WriteLine("Continue?(y/n):");
	string? continuePlaying = Console.ReadLine()?.ToLower().Trim();
	if(continuePlaying == "n" || continuePlaying == "no")
	{
		continuePlayingBool = false;
	}

}