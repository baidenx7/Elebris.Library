using System;

[Serializable]
public struct PreparedActionBehaviour
{
   
    public float actionDuration; //Time til gamebobject is removed
    public float actionSpeed; //travel speed of the gameobject
   
    public NumAffectedTargets targetsHitToDestroy; //some skills will stay their whole duration, or pierce etc


    public PreparedActionBehaviour(float actionDuration,
        float actionSpeed, NumAffectedTargets destroyOnContact  = NumAffectedTargets.Single)
    {
        this.actionDuration = actionDuration;
        this.actionSpeed = actionSpeed;
        this.targetsHitToDestroy = destroyOnContact;
    }
}



