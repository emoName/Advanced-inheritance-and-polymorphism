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
        string Name { get; set; }
        String GetStdPackage { get; }
    }

    interface ITeam
    {
        String TeamName { get; set; }
        ITeam AddPlayer(IPlayer p);
        void ShowPlayers();
    }
    //  sar putea de impartit in 2 interfete {ITeamAdd : ITeamGet}

    interface IGameShowInfo
    {
        void ShowGameName();
        String GetScore();
        // String GetOponent();
        string GetOponent();

    }

    interface IGameAddTeam
    {
        IGameAddTeam AddTeam(ITeam team);
    }

    interface ITwoTeamsGame: IGameShowInfo
    {
        void ShowPlayersAndTeams();
    }


}
