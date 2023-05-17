using System;
using System.Collections.Generic;
using FootBall_team_app.Functionality;
using FootBall_team_app.Model;
using FootBall_team_app.Service;

namespace FootBall_team_app.UI
{
    class EntryPoint
    {
        public static void Main()
        {
           

            IManage service = new Services();

            bool flag=true;
            while (flag)
            {
                int n;
                Console.WriteLine("Enter 1 For Add Player..");
                Console.WriteLine("Enter 2 For Get Player list..");
                Console.WriteLine("Enter 3 For Update Player..");
                Console.WriteLine("Enter 4 For Delete Player..");
                Console.WriteLine("Enter 5 For Search Player..");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Enter your choice...");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        PlayersDetail obj = new PlayersDetail();

                        Console.WriteLine("Enter Player  Number : ");
                        obj.playerNo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Player Name : ");
                        obj.playerName = Console.ReadLine();
                        Console.WriteLine("Enter Player Position : ");
                        obj.playerPosition = Console.ReadLine();
                        service.addPlayer(obj);
                        break;
                    case 2:
                        service.GetPlayer();
                        break;
                    case 3:
                        Console.WriteLine("Enter Player Number to replace ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        service.updatePlayer(id);
                        break;
                    case 4:
                        Console.WriteLine("Enter Player Number to Remove ");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        service.deletePlayer(id1);
                        break;
                    case 5:
                        Console.WriteLine("Enter Player Number to search.");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        service.SearchPlayer(id2);
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice..");
                        break;

                }
                string ch;
                Console.WriteLine("Do you want to Continue ? Enter 'Y' for Yes. Otherwise Press 'N'");
                ch = Console.ReadLine();
                if (ch == "Y" || ch == "y")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }


        }
    }
}
