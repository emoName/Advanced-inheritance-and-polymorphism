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

       abstract public   void GameName();
        protected SingePlayerGame()
        {
            score = 0;

        }

        private int score;

        public string PlayerName { get; set; }

        public string GetScore()
        {
            return $"The score is : {score} ";
        }

        public string ShowOponent()
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

        abstract public void GameName();
        public virtual void AddTeam(ITeam team)
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

        public virtual string GetScore()
        {

            return $"Score is : | {teams[0].TeamName} : {team1Score} vs {teams[1].TeamName} : {team2Score}  |";
        }

        public virtual string ShowOponent()
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
                        teams[0].GetPlayers();

                        Console.WriteLine(teams[1].TeamName);
                        teams[1].GetPlayers();
                        break;
                    case 1:
                        Console.WriteLine(teams[0].TeamName);
                        teams[0].GetPlayers();
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
