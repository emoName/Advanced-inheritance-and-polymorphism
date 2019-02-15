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
    //  sar putea de impartit in 2 interfete {ITeamAdd : ITeamGet}

    interface IGameShowInfo
    {

        String GetScore();
        // String ShowOponent();
        string ShowOponent();

    }

    interface IGameAddTeam
    {
        void AddTeam(ITeam team);
    }

    interface ITwoTeamsGame: IGameShowInfo
    {
        void ShowPlayersAndTeams();
    }


}
