namespace TryToWriteACode.Factory_Method
{
    abstract class Enemy
    {
        public string EnemyName { get; set; }
        public int Damage { get; set; }
        public float Weight { get; set; }
        public string Difficulty { get; set; }
        public float Health { get; set; }
    }
}
