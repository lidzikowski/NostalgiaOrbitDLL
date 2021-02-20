using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossDevolarium : AbstractEnemy
    {
        public static BossDevolarium Instance { get; } = new BossDevolarium();
        public BossDevolarium()
        {
            EnemyType = PrefabTypes.BossDevolarium;

            MakeBoss(Devolarium.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 8));
        }
    }
}