using System;


namespace rock_scissors_paper_game
{
    //public class One1
    //{
    //    public One1()
    //    {
    //        Console.WriteLine("");
    //        Kata.= "ght";
    //    }

    //}
    public class Kata//:One1
    {
        
        
        public static string RPSLP(string player1, string player2) //=> (player1, player2) switch
        {
            // valid names:  scissor, paper, rock, lizard, spock
            // valid return:  "Player 1 won!", "Player 2 won!", "Draw!", "Oh, Unknown Thing"

            //player1 = player1.ToLower() ?? "";
            //player2 = player2.ToLower() ?? "";

            //(player1, player2) = (player1.ToLower(),player2.ToLower());

            //player1 ??= "";
            //player2 ??= "";
            
            //(player1, player2) = (player1 ?? "", player2 ?? "");
            return (player1.ToLower(), player2.ToLower()) switch
            {
                ("scissor", "paper") => "Player 1 won!",
                ("scissor", "lizard") => "Player 1 won!",
                ("scissor", "rock") => "Player 2 won!",
                ("scissor", "spock") => "Player 2 won!",
                ("paper", "rock") => "Player 1 won!",
                ("paper", "spock") => "Player 1 won!",
                ("paper", "lizard") => "Player 2 won!",
                ("paper", "scissor") => "Player 2 won!",
                ("rock", "lizard") => "Player 1 won!",
                ("rock", "spock") => "Player 2 won!",
                ("rock", "paper") => "Player 2 won!",
                ("rock", "scissor") => "Player 1 won!",
                ("lizard", "paper") => "Player 1 won!",
                ("lizard", "scissor") => "Player 2 won!",
                ("lizard", "rock") => "Player 2 won!",
                ("lizard", "spock") => "Player 1 won!",
                ("spock", "paper") => "Player 2 won!",
                ("spock", "scissor") => "Player 1 won!",
                ("spock", "rock") => "Player 1 won!",
                ("spock", "lizard") => "Player 2 won!",
                ("scissor", "scissor") => "Draw!",
                ("paper", "paper") => "Draw!",
                ("rock", "rock") => "Draw!",
                ("lizard", "lizard") => "Draw!",
                ("spock", "spock") => "Draw!",
                (_, _) => "Oh, Unknown Thing",
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
