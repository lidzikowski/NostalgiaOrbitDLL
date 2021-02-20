using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossLordakium : AbstractEnemy
    {
        public static BossLordakium Instance { get; } = new BossLordakium();
        public BossLordakium()
        {
            EnemyType = PrefabTypes.BossLordakium;

            MakeBoss(Lordakium.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 32));
        }
    }
}