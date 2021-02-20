using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossLordakia : AbstractEnemy
    {
        public static BossLordakia Instance { get; } = new BossLordakia();
        public BossLordakia()
        {
            EnemyType = PrefabTypes.BossLordakia;

            MakeBoss(Lordakia.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Prometid, 10));
            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 1));
        }
    }
}