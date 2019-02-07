using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Team
    {
        // Team
        List<Player> player = new List<Player>() ;

        public void AddPlayer(String name)
        {
            player.Add(new Player() { Name = name });
   
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

    class Player
    {
       public Player() {
            Name = "NoName";
        }
        public String Name { get; set; }


    }



}
