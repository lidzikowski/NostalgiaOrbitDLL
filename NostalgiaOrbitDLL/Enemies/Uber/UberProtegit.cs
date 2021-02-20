using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberProtegit : AbstractEnemy
    {
        public static UberProtegit Instance { get; } = new UberProtegit();
        public UberProtegit()
        {
            EnemyType = PrefabTypes.UberProtegit;

            MakeUber(BossProtegit.Instance);
        }
    }
}