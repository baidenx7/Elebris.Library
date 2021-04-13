using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.Actions.Modification
{
    public struct ActionRules
    {
        //TODO Sets not lists
        public readonly List<ActionTag> AndTags;
        public readonly List<ActionTag> OrTags;
        public readonly List<ActionTag> NotTags;


        public ActionRules(List<ActionTag> and, List<ActionTag> or, List<ActionTag> not)
        {
            AndTags = and;
            OrTags = or;
            NotTags = not;
        }

        public bool TagsPass(ActionRules rules)
        {
            if (AndCheck(rules.AndTags)
                && OrCheck(rules.OrTags)
                && NotCheck(rules.NotTags)
                )
            {
                return true;
            }
            return false;
        }

        private bool AndCheck(List<ActionTag> and)
        {
            return true;
        }
        private bool OrCheck(List<ActionTag> or)
        {
            return true;
        }
        private bool NotCheck(List<ActionTag> not)
        {
            return true;
        } 


    }
    //every possible action tag goes in here
    public enum ActionTag
    {
        AreaOfEffect,
        Fire,
        Attack,
        Heal,
        Buff,
        Maneuver
    }
}
