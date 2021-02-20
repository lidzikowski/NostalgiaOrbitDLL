using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberDevolarium : AbstractEnemy
    {
        public static UberDevolarium Instance { get; } = new UberDevolarium();
        public UberDevolarium()
        {
            EnemyType = PrefabTypes.UberDevolarium;

            MakeUber(BossDevolarium.Instance);
        }
    }
}