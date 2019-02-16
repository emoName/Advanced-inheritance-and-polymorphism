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
            SomeSinglePlayerGame someSinglePlayerGame = new SomeSinglePlayerGame() { PlayerName = "joraCocs" };
            Team team = new Team() { TeamName = "TI" };
            Player player = new Player() { Name = "Ion" };

            AddPlayerToTeam(player, team);
            AddPlayerToTeam(new Player() { Name = "Vasea" }, team);
            AddPlayerToTeam(new Player() { Name = "george" }, team);

            AddTeamToGame(team, basket);
            AddTeamToGame(team, fotball);

            team = new Team() { TeamName = "FAF" };
            AddPlayerToTeam(new Player() { Name = "Nicu" }, team);
            AddPlayerToTeam(new Player() { Name = "Vasea" }, team);
            AddPlayerToTeam(player, team);

            AddTeamToGame(team, basket);
            AddTeamToGame(team, fotball);

            InfoGame(new List<IGameShowInfo> { basket, fotball, someSinglePlayerGame });
            Console.WriteLine("\n -xxx------------------------------------------------------- \n");
            //  ShowGamesAndTeams(new List<IGameShowInfo>() { basket, fotball, someSinglePlayerGame });
            ShowTwoTeamGameInfo(new List<ITwoTeamsGame> { basket, fotball });

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
        public static void InfoGame(List<IGameShowInfo> game)
        {
            foreach (var g in game)
            {
                g.GameName();
                Console.WriteLine(g.ShowOponent());
                Console.WriteLine(g.GetScore());
                Console.WriteLine();
            }
        }


        public static void ShowTwoTeamGameInfo(List<ITwoTeamsGame> game)
        {
            foreach (var g in game)
            {
                g.GameName();
                g.ShowOponent();
                g.ShowPlayersAndTeams();
                Console.WriteLine();
            }


        }

        //public static void ShowGamesAndTeams(List<IGameShowInfo> games)
        //{
        //    //Liskov efect
        //    foreach (IGameShowInfo g in games)
        //    {
        //        g.ShowOponent();
        //        Console.WriteLine("\n -------------------------------------------------------- \n");
        //    }
        //}
    }
}
