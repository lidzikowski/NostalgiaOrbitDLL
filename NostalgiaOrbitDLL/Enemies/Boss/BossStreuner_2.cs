using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossStreuner_2 : AbstractEnemy
    {
        public static BossStreuner_2 Instance { get; } = new BossStreuner_2();
        public BossStreuner_2()
        {
            EnemyType = PrefabTypes.BossStreuner_2;

            MakeBoss(Streuner_2.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 4));
        }
    }
}