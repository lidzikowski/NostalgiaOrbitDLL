using System;

namespace NostalgiaOrbitDLL.Maps
{
    [Serializable]
    public class EnemyMap
    {
        public PrefabTypes EnemyType { get; protected set; }

        public int Quantity { get; protected set; }
        public int SpawnEverySecond { get; set; }

        public PositionVector AreaSpawn_Min { get; protected set; }
        public PositionVector AreaSpawn_Max { get; protected set; }

        //public bool IsGalaxyGate { get; protected set; }
        //public int Wave { get; protected set; }
        //public int SpawnWaveEverySecond { get; protected set; }
        //public int AreaSpawn_Circle { get; protected set; }

        public EnemyMap(PrefabTypes enemyType, int quantity, AbstractMap abstractMap)
        {
            EnemyType = enemyType;
            Quantity = quantity;
            AreaSpawn_Min = abstractMap.GetCalculatePosition(Positions.TopLeft);
            AreaSpawn_Max = abstractMap.GetCalculatePosition(Positions.BottomRight);
        }
        public EnemyMap(PrefabTypes enemyType, int quantity, PositionVector areaSpawn_Min, PositionVector areaSpawn_Max)
        {
            EnemyType = enemyType;
            Quantity = quantity;
            AreaSpawn_Min = areaSpawn_Min;
            AreaSpawn_Max = areaSpawn_Max;
        }

    }
}