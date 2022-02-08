namespace TryToWriteACode.Factory_Method
{
    class CreateSpider : CreateEnemy
    {
        public override Enemy CreateEnemyMethod()
        {
            return new Spider();
        }
    }
}
