using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 class Player
    {
       public Player() {
            Name = "NoName";
        }
        public String Name { get; set; }


    }

    class Team
    {
       
        List<Player> player = new List<Player>() ;
        public String TeamName { get; set; }

        public void AddPlayer(Player p)
        {
            player.Add(p );
   
        }
        public void GetPlayers()
        {
            if (player.Count > 0)
                foreach (Player p in player)
                {
                    Console.WriteLine($"Player Name : { p.Name}");
                }
            else Console.WriteLine("Is no any plaers in the List !!!");
        }
    }
    
    interface IGame
    {
       

         String GetScore();
         String GetTeams();

         void AddTeam(Team team);


    }

  
    class Basket :  IGame
    {
        private Team[] teams = new Team[2];
        private int id = 0;
        private int team1Score = 0;
        private int team2Score = 0;
        public  void AddTeam(Team team)
        {
            if (id < 2)
            {
                teams[id] = team;
                id++;
            }
            else
            {
                Console.WriteLine("In game can be only 2 Teams !");
            }
        }

        public  string GetScore()
        {

            return $"Score is : | {teams[0].TeamName} : {team1Score} vs {teams[1].TeamName} : {team2Score}  |";
        }

        public  string GetTeams()
        {
            return $" {teams[0].TeamName} vs {teams[1].TeamName}";
        }
    }


    class Fotball : IGame
    {
        private int id = 0;
        private int team1Score = 0;
        private int team2Score = 0;
        private Team[] teams = new Team[2];
        public void AddTeam(Team team)
        {
            if (id < 2)
            {
                teams[id] = team;
                id++;
            }
            else
            {
                Console.WriteLine("In game can be only 2 Teams !");
            }
        }

        public string GetScore()
        {

            return $"Score is : | {teams[0].TeamName} : {team1Score} vs {teams[1].TeamName} : {team2Score}  |";
        }

        public string GetTeams()
        {
            return $" {teams[0].TeamName} vs {teams[1].TeamName}";
        }
    }






}
