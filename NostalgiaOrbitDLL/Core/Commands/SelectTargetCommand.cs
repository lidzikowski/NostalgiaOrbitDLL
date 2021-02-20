using System;

namespace NostalgiaOrbitDLL.Core.Commands
{
    [Serializable]
    public class SelectTargetCommand : AbstractCommand
    {
        public Guid? TargetId { get; set; }
        public bool? AttackAmmunition { get; set; }
        public bool? AttackRocket { get; set; }

        public SelectTargetCommand(Guid? targetId, bool? attackAmmunition, bool? attackRocket)
        {
            TargetId = targetId;
            AttackAmmunition = attackAmmunition;
            AttackRocket = attackRocket;
        }
    }
}