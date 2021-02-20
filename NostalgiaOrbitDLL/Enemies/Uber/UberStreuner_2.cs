using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberStreuner_2 : AbstractEnemy
    {
        public static UberStreuner_2 Instance { get; } = new UberStreuner_2();
        public UberStreuner_2()
        {
            EnemyType = PrefabTypes.UberStreuner_2;

            MakeUber(BossStreuner_2.Instance);
        }
    }
}