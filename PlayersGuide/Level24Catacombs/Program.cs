﻿using static Level24Catacombs.CardColors;
using static Level24Catacombs.CardRanks;
using static Level24Catacombs.DoorStates;

namespace Level24Catacombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point();
            //ColorCall();
            //Card();
            LockedDoor();
        }

        static void Point()
        {
            Point One = new Point(2, 3);
            Point Two = new Point(-4, 0);

            Console.WriteLine($"({One.XCoordinate}, {One.YCoordinate})");
            Console.WriteLine($"({Two.XCoordinate}, {Two.YCoordinate})");
        }

        static void ColorCall()
        {
            Color random = new Color(180, 180, 180);
            Color blue = Color.Blue;

            Console.WriteLine($"{random}");
            Console.WriteLine($"{blue}");
        }

        static void Card()
        {
            CardColor[] colors = { CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow };
            CardRank[] ranks = { CardRank.One, CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, CardRank.DollarSign, CardRank.Caret, CardRank.PercentSign, CardRank.Ampersand };

            foreach (CardColor color in colors)
            {
                foreach (CardRank rank in ranks)
                {
                    Console.WriteLine($"The {color} {rank}");
                }
            }
        }

        static void LockedDoor()
        {

            int initialPasscode = GetNumber("What is the initial passcode?");
            Door door = new(initialPasscode);

            while (true)
            {
                Console.WriteLine($"The door is {LowerCase(door.CurrentState)}. What do you want to do? (open, close, lock, unlock, change passcode)");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "open":
                        door.OpenDoor();
                        break;
                    case "close":
                        door.CloseDoor();
                        break;
                    case "lock":
                        door.LockDoor();
                        break;
                    case "unlock":
                        door.UnlockDoor(initialPasscode);
                        break;
                    case "change passcode":
                        int currentPasscode = GetNumber("What is the current passcode?");
                        int newPasscode = GetNumber("What do you want to change it to?");
                        door.ChangePasscode(currentPasscode, newPasscode);
                        break;
                    default:
                        Console.WriteLine("Nothing happened. Please use the correct command.");
                        break;

                }
            }

            int GetNumber(string input)
            {
                Console.WriteLine(input);
                return Convert.ToInt32(Console.ReadLine());
            }
            string LowerCase(DoorState doorState)
            {
                return doorState.ToString().ToLower();
            }
        }
    }
}