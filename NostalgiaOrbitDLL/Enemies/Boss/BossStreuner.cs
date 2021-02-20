using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossStreuner : AbstractEnemy
    {
        public static BossStreuner Instance { get; } = new BossStreuner();
        public BossStreuner()
        {
            EnemyType = PrefabTypes.BossStreuner;

            MakeBoss(Streuner.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Terbium, 10));
        }
    }
}