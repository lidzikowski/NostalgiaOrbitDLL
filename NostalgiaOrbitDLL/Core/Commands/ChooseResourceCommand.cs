using NostalgiaOrbitDLL.Core.Exceptions;
using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class ChooseResourceCommand : AbstractCommand
    {
        public ResourceTypes? Ammunition { get; set; }
        public ResourceTypes? Rocket { get; set; }

        public ChooseResourceCommand(ResourceTypes ammunition, ResourceTypes rocket)
        {
            if (!DLLHelpers.IsAmmunitionType(ammunition))
                throw new ResourceException();

            if (!DLLHelpers.IsRocketType(rocket))
                throw new ResourceException();

            Ammunition = ammunition;
            Rocket = rocket;
        }
    }
}