using System;

[Serializable]
public struct PreparedActionBehaviour
{

    public float actionDuration; //Time til gamebobject is removed
    public float actionSpeed; //travel speed of the gameobject
    public int NumberOfReactions { get; set; } //starts at 0, and every time a new target is hit, and that hit requires a new object being created,
                                               //pass in the value +1. especially with recursive actions, they'll need to know whether or not to permit something to 
                                               //continue to exist based on current hits.
                                               //alternatively reverse this, default to 1 and tie in skill removal to the value hitting 0
                                               //OR create a list, with removal conditions (time, distance, units hit) that contains observers which listen for certain events,
                                               //and a bool (AllFalse) that lets the skill know if it needs a single observer to return false from a CanLive bool,
                                               //or all of them before it kills the skill.  
    public NumAffectedTargets targetsHitToDestroy; //some skills will stay their whole duration, or pierce etc


    public PreparedActionBehaviour(float actionDuration,
        float actionSpeed, NumAffectedTargets destroyOnContact = NumAffectedTargets.Single, int num = 0)
    {
        this.actionDuration = actionDuration;
        this.actionSpeed = actionSpeed;
        this.targetsHitToDestroy = destroyOnContact;
        NumberOfReactions = num;
    }
}



