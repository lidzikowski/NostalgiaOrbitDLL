using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossProtegit : AbstractEnemy
    {
        public static BossProtegit Instance { get; } = new BossProtegit();
        public BossProtegit()
        {
            EnemyType = PrefabTypes.BossProtegit;

            MakeBoss(Protegit.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 4));
        }
    }
}