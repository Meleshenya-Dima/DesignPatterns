namespace TryToWriteACode.Factory_Method
{
    class CreateSlime : CreateEnemy
    {
        public override Enemy CreateEnemyMethod()
        {
            return new Slime();
        }
    }
}
