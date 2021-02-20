using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossMordon : AbstractEnemy
    {
        public static BossMordon Instance { get; } = new BossMordon();
        public BossMordon()
        {
            EnemyType = PrefabTypes.BossMordon;

            MakeBoss(Mordon.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 4));
        }
    }
}