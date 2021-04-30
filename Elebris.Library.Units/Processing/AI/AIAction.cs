using System;

namespace Elebris.Rpg.Library.Units.InputResponse.AI
{
    /// <summary>
    /// Contains the "logic" of button presses. So you control what a unit wants to press when here
    /// </summary>
    [Serializable]
    public class AIAction
    {
        public float minActionDelay = .3f, maxActionDelay = 1; // optionally add a little variability to time between actions
        public float actionWeightIncrease = 50; //default parameter for how much to increase Weight by after use
        public float minRange = .2f, maxRange = 2;

        public float currentWeight = 100;
        public ActionSlot slot = ActionSlot.select;



        public AIAction(ActionSlot slot)
        {
            this.slot = slot;
        }

        public void ChangeWeight(float amount = -5, float multiplier = .9f)
        {
            currentWeight *= multiplier;
            currentWeight += amount;
        }

        public bool CheckAction(float distance)
        {
            //each action is either true and has weight increased or false and has it slightly decreased
            //Debug.Log(actionRange + " range" + distance + " and distance");
            if (maxRange > distance)
            {
                ChangeWeight(actionWeightIncrease, 1);
                return true;
            }
            else
            {
                ChangeWeight();
                return false;

            }
        }
    }
}
