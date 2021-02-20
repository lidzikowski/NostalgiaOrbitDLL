using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossKristallin : AbstractEnemy
    {
        public static BossKristallin Instance { get; } = new BossKristallin();
        public BossKristallin()
        {
            EnemyType = PrefabTypes.BossKristallin;

            MakeBoss(Kristallin.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 8));
        }
    }
}