using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberKristallon : AbstractEnemy
    {
        public static UberKristallon Instance { get; } = new UberKristallon();
        public UberKristallon()
        {
            EnemyType = PrefabTypes.UberKristallon;

            MakeUber(BossKristallon.Instance);
        }
    }
}