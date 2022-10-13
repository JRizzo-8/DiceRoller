Console.WriteLine("Welcome to the Magic Dice Game(tm)!");
Console.WriteLine("Please choose a number of sides for the two die");
int userSideChoice = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
bool gambleMore = true;

RollTheDice();

void RollTheDice()
{
    int tries = 1;
    while (gambleMore == true)
    {

        
        int firstRoll = GenerateRandomNumbers(userSideChoice);
        int secondRoll = GenerateRandomNumbers(userSideChoice);
        int dieTotal = firstRoll + secondRoll;
        Console.WriteLine($"roll {tries}: ");
        tries++;

        Console.WriteLine($"You rolled a {firstRoll} and a {secondRoll}, thats a total of {dieTotal}");
        if (userSideChoice == 6)
        { Console.WriteLine(ReactToSixSideDice(firstRoll, secondRoll)); }

        Console.WriteLine("Would you like to roll the dice again? enter n or no to quit, any other key will continue");
        string playAgain = Console.ReadLine().ToLower();
        switch (playAgain)
        {
            case "n":
            case "no":
                Console.WriteLine("Thanks for rolling my dice, have a great day!");
                gambleMore = false;
                break;
            default:
                gambleMore = true;
                break;
        }
    }
    int GenerateRandomNumbers(int diceSides)
    {
        int diceRoll = rnd.Next(1, diceSides + 1);
        return diceRoll;
    }
    string ReactToSixSideDice(int firstDieValue, int secondDieValue)
    {
        int dieSixTotal = firstDieValue + secondDieValue;
        string message = "";

        if (firstDieValue == 1 && secondDieValue == 1)
        { message = "Snake Eyes!"; }
        else if ((firstDieValue == 1 && secondDieValue == 2) || (firstDieValue == 2 && secondDieValue == 1))
        { message = "Ace Deuce!"; }
        else if (firstDieValue == 6 && secondDieValue == 6)
        { message = "Box Cars!"; }
        else if (dieSixTotal == 7 || dieSixTotal == 11)
        { message = "Win!"; }
        else if (dieSixTotal == 2 || dieSixTotal == 3 || dieSixTotal == 12)
        { message = "Craps!"; }


        return message;
    }
    string ReactToTenSidedDice(int firstDieValue, int secondDieValue)
    {
        int dieTenTotal = firstDieValue + secondDieValue;
        string message = "";

        if (firstDieValue == 10 && secondDieValue == 10)
        { message = "Ten Pence!"; }
        else if (firstDieValue == 5 && secondDieValue == 5)
        { message = "Wild Fives!"; }
        else if (firstDieValue == 8 && secondDieValue == 8)
        { message = "crrraaaaaazy eights!"; }
        else if (dieTenTotal == 20)
        { message = "Maximum Score!"; }
        else if (firstDieValue == 4 && secondDieValue == 4)
        { message = "Fourza Motorsports!"; }
        else if (firstDieValue == 3 && secondDieValue == 6 && dieTenTotal == 9)
        { message = "Whoa she fine, can you sock it to me one more time get looow"; }


        return message;
    }
}