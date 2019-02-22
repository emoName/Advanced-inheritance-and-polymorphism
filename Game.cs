using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player : IPlayer
    {
        public Player()
        {
            Name = "NoName";
            Age = 18;
            PowerPoints = 88;
        }

        public String Name { get; set; }
        private int Age { get; set; }
        private int PowerPoints { get; set; }
        public String GetStdPackage
        {
            get
            {
                return $"{Name} : {Age} Years : {PowerPoints} Points";
            }
        }
    }


    class Team : ITeam
    {

        List<IPlayer> player = new List<IPlayer>();
        public String TeamName { get; set; }

        public ITeam AddPlayer(IPlayer p)
        {
            player.Add(p);
            return this;
        }
        public void ShowPlayers()
        {
            int i = 1;
            if (player.Count > 0)
                foreach (IPlayer p in player)
                {
                    Console.WriteLine($"Player {i} Name : { p.Name}");
                    i++;
                }
            else Console.WriteLine("Is no any plaers in the List !!!");
        }
    }

    public class BasketTeam : ITeam
    {
        public string TeamName { get; set => throw new NotImplementedException(); }

        public ITeam AddPlayer(IPlayer p)
        {
            throw new NotImplementedException();
        }

        public void ShowPlayers()
        {
            throw new NotImplementedException();
        }
    }



    class Basket : TwoTeamsGames
    {

        public override void ShowGameName()
        {
            Console.WriteLine("This Game name Is : Basket : ");
        }

        //-----  Open Close ----- add Feature ------
        public override void ShowPlayersAndTeams()
        {
            Console.WriteLine(teams[0].TeamName);
            teams[0].ShowPlayers();

            Console.WriteLine(teams[1].TeamName);
            teams[1].ShowPlayers();
        }


    }


    class Fotball : TwoTeamsGames
    {

        //-----  Open Close ----- add Feature ------

        public override void ShowGameName()
        {
            Console.WriteLine("This Game name Is : Fotball : ");
        }

    }

    // imaginatia level God  :)
    // trying to implement Liskov :D


  

    class SomeSinglePlayerGame  : SingePlayerGame
    {
        public override void ShowGameName()
        {
            Console.WriteLine("This Game name Is : SomeSinglePlayerGame : ");
        }

    }





}
