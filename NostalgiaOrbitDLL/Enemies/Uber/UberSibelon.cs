using System;

namespace NostalgiaOrbitDLL.Enemies
{
    [Serializable]
    public class UberSibelon : AbstractEnemy
    {
        public static UberSibelon Instance { get; } = new UberSibelon();
        public UberSibelon()
        {
            EnemyType = PrefabTypes.UberSibelon;

            MakeUber(BossSibelon.Instance);
        }
    }
}