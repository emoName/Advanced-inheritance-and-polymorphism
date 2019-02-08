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
            int i = 1;
            if (player.Count > 0)
                foreach (Player p in player)
                {
                    Console.WriteLine($"Player {i} Name : { p.Name}");
                    i++;
                }
            else Console.WriteLine("Is no any plaers in the List !!!");
        }
    }
    
    interface IGame
    {
       

         String GetScore();
         String GetTeams();

         void AddTeam(Team team);
         void ShowPlayersAndTeams();


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

        //-----  Open Close ----- add Feature ------

        public void ShowPlayersAndTeams()
        {
            Console.WriteLine(teams[0].TeamName);
            teams[0].GetPlayers();

            Console.WriteLine(teams[1].TeamName);
            teams[1].GetPlayers();
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
            switch (teams.Length)
            {
                case 2: return $" {teams[0].TeamName} vs {teams[1].TeamName}";
                case 1: return $" {teams[0].TeamName}";
                default : return "Is no any Teams in Game !!!";

            }
        }

        //-----  Open Close ----- add Feature ------

        public void ShowPlayersAndTeams()
        {
            try
            {

           
            switch (teams.Length)
            {
                case 2:
                    Console.WriteLine(teams[0].TeamName);
                    teams[0].GetPlayers();

                    Console.WriteLine(teams[1].TeamName);
                    teams[1].GetPlayers();
                    break;
                case 1:
                     Console.WriteLine(teams[0].TeamName);
                     teams[0].GetPlayers();
                    break;
               default :
                     Console.WriteLine( "Is no any Teams in Game !!!");
                    break;

            }

            }
            catch (NullReferenceException e)
            {

                
            }
        }
    }






}
