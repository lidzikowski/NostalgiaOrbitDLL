using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossSibelonit : AbstractEnemy
    {
        public static BossSibelonit Instance { get; } = new BossSibelonit();
        public BossSibelonit()
        {
            EnemyType = PrefabTypes.BossSibelonit;

            MakeBoss(Sibelonit.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 8));
        }
    }
}