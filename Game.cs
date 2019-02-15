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
        public String StdPackage
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

        public void AddPlayer(IPlayer p)
        {
            player.Add(p);

        }
        public void GetPlayers()
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





    class Basket : TwoTeamsGames
    {



        //-----  Open Close ----- add Feature ------
        public override void ShowPlayersAndTeams()
        {
            Console.WriteLine(teams[0].TeamName);
            teams[0].GetPlayers();

            Console.WriteLine(teams[1].TeamName);
            teams[1].GetPlayers();
        }


    }


    class Fotball : TwoTeamsGames
    {

        //-----  Open Close ----- add Feature ------



    }

    // imaginatia level God  :)
    // trying to implement Liskov :D


  

    class SomeSinglePlayerGame  : SingePlayerGame
    {
      
     
    }





}
