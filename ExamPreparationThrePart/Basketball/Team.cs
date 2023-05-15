using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private List<Player> players;
        public Team(string name, int openPositions, char group)
        {
            this.Name = name;
            this.OpenPositions = openPositions;
            this.Group = group;
            this.players = new List<Player>();
        }

        public string Name { get; private set; }
        public int OpenPositions { get; private set; }
        public char Group { get; private set; }
        public IReadOnlyCollection<Player> Players => this.players;

        public int Count => this.Players.Count;


        public string AddPlayer(Player player)
        {

            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            else if (this.OpenPositions == 0)
            {
                return "There are no more open positions.";
            }
            else if (player.Rating < 80)
            {

                return "Invalid player's rating.";
            }
            else
            {

                this.players.Add(player);
                OpenPositions--;
                return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPositions}.";
            }





        }

        public bool RemovePlayer(string name)
        {
            var isValid = this.players.FirstOrDefault(p => p.Name == name);
            if (isValid == null)
            {
                return false;

            }
            this.OpenPositions++;
            this.players.Remove(isValid);
            return true;
            //for (int i = 0; i < players.Count; i++)
            //{
            //    if (name == players[i].Name)
            //    {
            //        players.Remove(players[i]);
            //        OpenPositions++;
            //        return true;
            //    }

            //}

        }

        public int RemovePlayerByPosition(string position)
        {
            int counter = 0;
            while (this.Players.FirstOrDefault(x => x.Position == position) != null)
            {
                var target = this.Players.FirstOrDefault(x => x.Position == position);
                this.OpenPositions++;
                this.players.Remove(target);
                counter++;

            }
            //for (int i = 0; i < players.Count; i++)
            //{
            //    if (players[i].Position == position)
            //    {
            //        counter++;
            //        OpenPositions++;
            //        players.Remove(players[i]);
            //    }

            //}
            return counter;
        }
        public Player RetirePlayer(string name)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Name == name)
                {
                    if (players[i].Retired == false)
                    {

                        players[i].Retired = true;
                        return players[i];
                    }

                }


            }
            return null;
        }
        public List<Player> AwardPlayers(int games)
        {
            List<Player> awardPlayers = new List<Player>();
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Games >= games)
                {
                    awardPlayers.Add(players[i]);
                }
            }

            return awardPlayers;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");
            foreach (var player in players)
            {
                if (player.Retired == false)
                {
                    sb.AppendLine(player.ToString());

                }
            }

            return sb.ToString().Trim();

        }
    }
}
