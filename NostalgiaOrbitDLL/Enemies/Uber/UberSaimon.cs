using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberSaimon : AbstractEnemy
    {
        public static UberSaimon Instance { get; } = new UberSaimon();
        public UberSaimon()
        {
            EnemyType = PrefabTypes.UberSaimon;

            MakeUber(BossSaimon.Instance);
        }
    }
}