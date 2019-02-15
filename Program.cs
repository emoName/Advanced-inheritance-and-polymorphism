using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  SOLID :)

            Basket basket = new Basket();
            Fotball fotball = new Fotball();
            Team team = new Team() { TeamName = "TI" };
            Player player = new Player() { Name = "Ion" };

            AddPlayerToTeam(player, team);
            AddTeamToGame(team, basket);
            AddTeamToGame(team, fotball);

            player = new Player() { Name = "Nicu" };
            team = new Team() { TeamName = "FAF" };

            AddPlayerToTeam(player, team);
            AddTeamToGame(team, basket);
            AddTeamToGame(team, fotball);

            InfoGame(basket);
            Console.WriteLine("\n -xxx------------------------------------------------------- \n");
            ShowGamesAndTeams(new List<IGameShowInfo>() { basket, fotball, new SomeSinglePlayerGame() });
            ShowTwoTeamGameInfo(new List<ITwoTeamsGame> { basket, fotball});

            Console.ReadLine();

        }
        public static void AddTeamToGame(ITeam team, IGameAddTeam game)
        {
            game.AddTeam(team);
        }
        public static void AddPlayerToTeam(IPlayer player, ITeam team)
        {
            team.AddPlayer(player);
        }
        public static void InfoGame(IGameShowInfo game)
        {
            Console.WriteLine(game.ShowOponent());
            Console.WriteLine(game.GetScore());
        }

        public static void ShowGamesAndTeams(List<IGameShowInfo> games)
        {
            //Liskov efect
            foreach (IGameShowInfo g in games)
            {
                g.ShowOponent();
                Console.WriteLine("\n -------------------------------------------------------- \n");
            }
        }

        public static void ShowTwoTeamGameInfo(List<ITwoTeamsGame> game)
        {
            foreach (var g in game)
            {
                g.ShowPlayersAndTeams();
            }


        }

    }
}
