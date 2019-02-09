using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // Incapsulare
    public interface IPlayer
    {
        String Name { get; set; }
        String StdPackage { get; }
    }

    interface ITeam
    {
        String TeamName { get; set; }
        void AddPlayer(IPlayer p);
        void GetPlayers();
    }
    // conform Liskov sar putea de impartit in 2 interfete {ITeamAdd : ITeamGet}

    interface IGameShow
    {

        String GetScore();
        String GetTeams();
        void ShowPlayersAndTeams();

    }

    interface IGameAdd
    {
        void AddTeam(ITeam team);
    }




}
