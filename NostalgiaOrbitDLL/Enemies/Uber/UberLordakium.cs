using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberLordakium : AbstractEnemy
    {
        public static UberLordakium Instance { get; } = new UberLordakium();
        public UberLordakium()
        {
            EnemyType = PrefabTypes.UberLordakium;

            MakeUber(BossLordakium.Instance);
        }
    }
}