using System;
using System.Collections.Generic;
using FootBall_team_app.Model;
using FootBall_team_app.Functionality;

namespace FootBall_team_app.Service
{
    class Services:IManage
    {
        List<PlayersDetail> list = new List<PlayersDetail>();

        public int addPlayer(PlayersDetail temp)
        {
            list.Add(temp);
            return 1;
        }

        public List<PlayersDetail> GetPlayer()
        {
            foreach (PlayersDetail player in list)
            {
                Console.WriteLine("Player Number : "+ player.playerNo);
                Console.WriteLine("Player Name : "+ player.playerName);
                Console.WriteLine("Position : "+ player.playerPosition);
            }
            return list;
        }

        public void updatePlayer(int no)
        {
            List<PlayersDetail> player = GetPlayer();

            foreach (PlayersDetail pd in player)
            {
                if (no == pd.playerNo)
                {
                    pd.playerNo = no;
                    Console.WriteLine("Enter the new Name");
                    pd.playerName = Console.ReadLine();

                    Console.WriteLine("Enter your new position");
                    pd.playerPosition = (Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Number is not Matched.");
                }
                Console.WriteLine(pd.playerNo+" "+pd.playerName+" "+pd.playerPosition);
            }
        }

        public void deletePlayer(int no)
        {
            PlayersDetail pd = new PlayersDetail();
            List<PlayersDetail> list = GetPlayer();
            foreach (PlayersDetail pdetail in list)
            {
                if (no == pdetail.playerNo)
                {
                    pd = pdetail;
                }
            }
            if (list.Remove(pd))
            {
                Console.WriteLine("Id is Removed..");
            }
            else
            {
                Console.WriteLine("Id is not Matched..");
            }
        }

        public void SearchPlayer(int no)
        {
            PlayersDetail players = new PlayersDetail();
            List<PlayersDetail> list = GetPlayer();
            foreach (PlayersDetail temp in list)
            {
                Console.WriteLine("Name : " + temp.playerName);
                Console.WriteLine("Roll Number : " + temp.playerPosition);
            }
        }
    }
}
