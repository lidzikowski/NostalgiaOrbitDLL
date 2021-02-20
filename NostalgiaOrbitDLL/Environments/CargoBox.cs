using System;

namespace NostalgiaOrbitDLL.Environments
{
    [Serializable]
    public class CargoBox : AbstractEnvironment
    {
        public static CargoBox Instance { get; } = new CargoBox();
        public CargoBox()
        {
            PrefabType = PrefabTypes.CargoBox;
            OccupiedPrefabType = PrefabTypes.CargoBox_Occupied;

            IsCollectable = true;

            LifeTime = 20;
            OccupiedLifeTime = 10;
        }
    }
}