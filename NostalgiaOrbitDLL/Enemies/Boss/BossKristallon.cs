using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossKristallon : AbstractEnemy
    {
        public static BossKristallon Instance { get; } = new BossKristallon();
        public BossKristallon()
        {
            EnemyType = PrefabTypes.BossKristallon;

            MakeBoss(Kristallon.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 64));
        }
    }
}