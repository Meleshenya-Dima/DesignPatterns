namespace TryToWriteACode.Factory_Method
{
    class CreateWorm : CreateEnemy
    {
        public override Enemy CreateEnemyMethod()
        {
            return new Worm();
        }
    }
}
