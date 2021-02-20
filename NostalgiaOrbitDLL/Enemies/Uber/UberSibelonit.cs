using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberSibelonit : AbstractEnemy
    {
        public static UberSibelonit Instance { get; } = new UberSibelonit();
        public UberSibelonit()
        {
            EnemyType = PrefabTypes.UberSibelonit;

            MakeUber(BossSibelonit.Instance);
        }
    }
}