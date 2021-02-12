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
            


            (player1, player2) = (player1 ?? "", player2 ?? "");//check null

            //object call;
            //return (player1.ToLower(), player2.ToLower()) switch
            return   (new object()) switch //(call)
                        {
                            variants[player1].Contains(player2) => "Player 1 won!",
                            !variants[player1].Contains(player2) => "Player 1 won!",
                            _ => "Oh, Unknown Thing"
                   
                        };
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.RPSLP("spock", "spock"));
            Console.WriteLine(Kata.RPSLP(null, ""));
            Console.WriteLine(Kata.RPSLP("", null));
        }
    }
}
