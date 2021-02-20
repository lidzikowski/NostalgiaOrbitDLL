using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class BossSibelon : AbstractEnemy
    {
        public static BossSibelon Instance { get; } = new BossSibelon();
        public BossSibelon()
        {
            EnemyType = PrefabTypes.BossSibelon;

            MakeBoss(Sibelon.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 32));
        }
    }
}