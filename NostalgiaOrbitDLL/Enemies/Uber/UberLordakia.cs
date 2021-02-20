using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberLordakia : AbstractEnemy
    {
        public static UberLordakia Instance { get; } = new UberLordakia();
        public UberLordakia()
        {
            EnemyType = PrefabTypes.UberLordakia;

            MakeUber(BossLordakia.Instance);

            Cargo.Add(new Cargo(ResourceTypes.Duranium, 20));
            Cargo.Add(new Cargo(ResourceTypes.Promerium, 2));
        }
    }
}