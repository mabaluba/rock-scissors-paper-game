using System;
using System.Collections.Generic;
using System.Linq;


namespace rock_scissors_paper_game
{
    public class Kata
    {
        public static string RPSLP(string player1, string player2) //=> (player1, player2) switch
        {
            Dictionary<string,string[]> variants=new()
            {
                { "scissor", new[] { "paper", "lizard" } },
                { "paper", new[] { "spock", "rock" } },
                { "rock", new[] { "lizard", "scissor" } },
                { "lizard", new[] { "spock", "paper" } },
                { "spock", new[] { "rock", "scissor" } },
            };
            
            if ((player1==null ||player2== null)) return "Oh, Unknown Thing";
            else if (player1.ToLower() == player2.ToLower()) return "Draw!";
            else if (variants[player1].Contains(player2)) return "Player 1 won!";
            else return "Player 2 won!";
            
            //(player1, player2) = (player1.ToLower() ?? "", player2.ToLower() ?? "");//check null

                //var n = variants[player1].Contains(player2);
                //return (player1.ToLower(), player2.ToLower()) 

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.RPSLP("spock", "spock"));
            Console.WriteLine(Kata.RPSLP("spock", "paper"));
            Console.WriteLine(Kata.RPSLP(null, ""));
            Console.WriteLine(Kata.RPSLP("", null));
        }
    }
}
