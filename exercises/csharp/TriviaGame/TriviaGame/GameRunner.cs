﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
   public class GameRunner
    {

        private static bool notAWinner;

        public static void Main(string[] args)
        {
            Game aGame = new Game();

			var playerNames = new string[]
			{
				"Chet",
				"Pat",
				"Sue",
			};

            aGame.GeneratePlayerList(playerNames);

            Random rand = new Random(Int32.Parse(args[0]));

            do
            {

                aGame.MakeMoveBasedOnRoll(rand.Next(5) + 1);

                if (rand.Next(9) == 7)
                {
                    notAWinner = aGame.wrongAnswer();
                }
                else
                {
                    notAWinner = aGame.wasCorrectlyAnswered();
                }



            } while (notAWinner);

        }
    }
}
