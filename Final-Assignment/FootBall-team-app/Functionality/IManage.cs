using FootBall_team_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_team_app.Functionality
{
     interface IManage
    {
        int addPlayer(PlayersDetail temp);
        List<PlayersDetail> GetPlayer();
        void updatePlayer(int no);
        void deletePlayer(int no);
        void SearchPlayer(int no);

    }
}
