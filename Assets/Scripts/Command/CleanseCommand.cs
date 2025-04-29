using Command.Main;
using Command.Actions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanseCommand : UnitCommand
{
    private bool willHitTarget;

    public CleanseCommand(CommandData commandData)
    {
        this.commandData = commandData;
        willHitTarget = WillHitTarget();
    }

    public override bool WillHitTarget() => true;

    public override void Execute() => GameService.Instance.ActionService.GetActionByType(CommandType.Cleanse).PerformAction(actorUnit, targetUnit, willHitTarget);
}
