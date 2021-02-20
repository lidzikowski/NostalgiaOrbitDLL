using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberKristallin : AbstractEnemy
    {
        public static UberKristallin Instance { get; } = new UberKristallin();
        public UberKristallin()
        {
            EnemyType = PrefabTypes.UberKristallin;

            MakeUber(BossKristallin.Instance);
        }
    }
}