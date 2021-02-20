using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberStreuner : AbstractEnemy
    {
        public static UberStreuner Instance { get; } = new UberStreuner();
        public UberStreuner()
        {
            EnemyType = PrefabTypes.UberStreuner;

            MakeUber(BossStreuner.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Prometid, 2));
            Cargo.Add(new Cargo(ResourceTypes.Duranium, 2));
            Cargo.Add(new Cargo(ResourceTypes.Promerium, 2));
            Cargo.Add(new Cargo(ResourceTypes.Xenomit, 2));
        }
    }
}