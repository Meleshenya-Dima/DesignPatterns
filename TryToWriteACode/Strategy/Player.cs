namespace TryToWriteACode.Strategy
{
    class Player
    {
        public Player(IPlayerMove playerMove, string name)
        {
            PlayerMove = playerMove;
            Name = name;
        }

        public IPlayerMove PlayerMove { get; set; }
        public string Name { get; set; }
        public void GetPace()
        {
            PlayerMove.Move();
        }
    }
}
