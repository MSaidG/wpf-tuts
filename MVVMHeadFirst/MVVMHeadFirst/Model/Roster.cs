namespace MVVMHeadFirst.Model
{
    internal class Roster
    {
        public string TeamName { get; private set; }

        private readonly List<Player> _players = new List<Player>();
        public IEnumerable<Player> Players 
        { 
            get => new List<Player>(_players); 
        }

        public Roster(string teamName, List<Player> players)
        {
            TeamName = teamName;
            _players.AddRange(players);
        }
    }
}
