using Assets.Scripts.Units;
using Elebris.Actions.Library.Actions.Core;
using Elebris.Rpg.Library.Units.Resources.Models;

namespace Elebris.Rpg.Library.Units.Actions.Core
{
    public class ActivatableAction
    {
        public IActionBehaviour behaviour;
        public IActiveCoreAction containedAction;

        public ActivatableAction(IActionBehaviour behaviour, IActiveCoreAction containedAction, ResourceBarValue cooldown)
        {
            this.behaviour = behaviour;
            this.containedAction = containedAction;
            this.cooldown = cooldown;
        }


        public ResourceBarValue cooldown { get; set; }


    }
}
