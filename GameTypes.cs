using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{


  abstract  class SingePlayerGame : IGameShowInfo
    {

       abstract public   void ShowGameName();
        protected SingePlayerGame()
        {
            score = 98;

        }

        private int score;

        public string PlayerName { get; set; }

        public string GetScore()
        {
            return $"The score is : {score} ";
        }

        public string GetOponent()
        {
            return $" {PlayerName}  VS PC";
        }
    }

    abstract class TwoTeamsGames : IGameAddTeam, ITwoTeamsGame
    {
        protected ITeam[] teams = new ITeam[2];
        protected int team1Score = 0;
        protected int team2Score = 0;
        private int id = 0;

        abstract public void ShowGameName();
        public virtual IGameAddTeam AddTeam(ITeam team)
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
            return this;
        }

        public virtual string GetScore()
        {

            return $"Score is : | {teams[0].TeamName} : {team1Score} vs {teams[1].TeamName} : {team2Score}  |";
        }

        public virtual string GetOponent()
        {
            return $" {teams[0].TeamName} vs {teams[1].TeamName}";
        }

        public virtual void ShowPlayersAndTeams()
        {
            try
            {


                switch (teams.Length)
                {
                    case 2:
                        Console.WriteLine(teams[0].TeamName);
                        teams[0].ShowPlayers();

                        Console.WriteLine(teams[1].TeamName);
                        teams[1].ShowPlayers();
                        break;
                    case 1:
                        Console.WriteLine(teams[0].TeamName);
                        teams[0].ShowPlayers();
                        break;
                    default:
                        Console.WriteLine("Is no any Teams in Game !!!");
                        break;

                }

            }
            catch (NullReferenceException e)
            {


            }
        }


    }


}
