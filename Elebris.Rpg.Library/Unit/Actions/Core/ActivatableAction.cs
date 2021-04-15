using Assets.Scripts.Units;
using Elebris.Actions.Library.Actions.Component;
using Elebris.Actions.Library.Actions.Core;
using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Components;
using Elebris.Rpg.Library.Actions;
using Elebris.Rpg.Library.CharacterValues;
using System.Text;

namespace Elebris.Rpg.Library.ActionManager
{
    public class ActivatableAction
    {
        public IActionBehaviour behaviour;
        public ICoreAction containedAction;

        public ActivatableAction(IActionBehaviour behaviour, ICoreAction containedAction, ResourceBarValue cooldown)
        {
            this.behaviour = behaviour;
            this.containedAction = containedAction;
            this.cooldown = cooldown;
        }


        public ResourceBarValue cooldown { get; set; }

      
    }
}
