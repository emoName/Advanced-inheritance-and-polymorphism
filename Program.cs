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

         
            Basket basket = new Basket();
            Fotball fotball = new Fotball();

            Team team = new Team() {TeamName="TI" };
            Player player = new Player() { Name="Ion"};
            team.AddPlayer(player);
            basket.AddTeam(team);

            player = new Player() { Name = "Nicu" };
            team =new Team() { TeamName = "FAF" };
            team.AddPlayer(player);
            basket.AddTeam(team);

           Console.WriteLine( basket.GetTeams());

            basket.ShowPlayersAndTeams();

            Console.ReadLine();

        }


    }
}
