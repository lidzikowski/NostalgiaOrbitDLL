using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossSaimon : AbstractEnemy
    {
        public static BossSaimon Instance { get; } = new BossSaimon();
        public BossSaimon()
        {
            EnemyType = PrefabTypes.BossSaimon;

            MakeBoss(Saimon.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Promerium, 1));
            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 2));
        }
    }
}