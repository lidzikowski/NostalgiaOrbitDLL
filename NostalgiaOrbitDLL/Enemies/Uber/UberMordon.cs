using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberMordon : AbstractEnemy
    {
        public static UberMordon Instance { get; } = new UberMordon();
        public UberMordon()
        {
            EnemyType = PrefabTypes.UberMordon;

            MakeUber(BossMordon.Instance);
        }
    }
}